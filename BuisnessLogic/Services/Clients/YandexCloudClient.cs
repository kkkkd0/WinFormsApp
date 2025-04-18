﻿using Amazon;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BuisnesLogic.ServicesInterface;
using BuisnesLogic.Models;

namespace BuisnesLogic.Service.Clients
{
    public class YandexCloudClient : IYandexClient
    {
        private AmazonS3Config configurationAws = new AmazonS3Config() { ServiceURL = "https://s3.yandexcloud.net", RequestChecksumCalculation = Amazon.Runtime.RequestChecksumCalculation.WHEN_REQUIRED };
        public string baseBucket { get; set; }
        public YandexCloudClient(string clientawsid, string clientawssecret, string basebucket)
        {
            if(string.IsNullOrWhiteSpace(clientawsid) | string.IsNullOrWhiteSpace(clientawssecret) | string.IsNullOrWhiteSpace(basebucket)) throw new ArgumentNullException("args was null");
            var options = new CredentialProfileOptions()
            {
                AccessKey = clientawsid,
                SecretKey = clientawssecret,
            };
            var profile = new CredentialProfile("default", options)
            {
                Region = RegionEndpoint.USEast1
            };
            var sharedFile = new SharedCredentialsFile();
            sharedFile.RegisterProfile(profile);
            baseBucket = basebucket;
        }
        /// <summary>
        ///  Add Your file 
        /// </summary>
        /// <param name="file">bucketpath </param>
        /// <param name="postfix"> Is work from scheme basebacket + postfix</param>
        public async Task<AwsActionResultModel> AddModel(Stream file, string postfix, string nameofmodel)
        {
            if (string.IsNullOrWhiteSpace(postfix) | string.IsNullOrWhiteSpace(nameofmodel)) throw new NullReferenceException("args was null");
            AwsActionResultModel model = new AwsActionResultModel() { resultUrlFromModel = null, isCorrect = false };
            using (var client = new AmazonS3Client(configurationAws))
            {
                var conditionContinue = await Continue(client, baseBucket, file.CanRead);
                if (!conditionContinue) return model;
                var request = new PutObjectRequest()
                {
                    BucketName = baseBucket,
                    Key = postfix + "/" + nameofmodel,
                    InputStream = file,
                    StorageClass = S3StorageClass.Standard,
                };
                var resp = await client.PutObjectAsync(request);
                if (resp.HttpStatusCode == HttpStatusCode.OK)
                {
                    var url = await GetUrl(client, postfix + "/" + nameofmodel);
                    model.isCorrect = true;
                    model.resultUrlFromModel = url;
                    return model;
                }
                return model;
            }
        }
        public async Task<bool> DeleteModel(string postfix, string nameofmodel)
        {
            if (string.IsNullOrWhiteSpace(postfix) | string.IsNullOrWhiteSpace(nameofmodel)) throw new NullReferenceException("args was null");
            using (var client = new AmazonS3Client(configurationAws))
            {
                var conditionContinue = await Continue(client, baseBucket);
                if (!conditionContinue) { return false; }
                var request = new DeleteObjectRequest()
                {
                    BucketName = baseBucket,
                    Key = postfix + "/" + nameofmodel,
                };
                var task = client.DeleteObjectAsync(request);
                task.Wait();
                var resp = task.Result;
                return resp.HttpStatusCode == HttpStatusCode.NoContent ? true : false;
            }
        }
        public async Task<AwsActionResultModel> UpdateModel(Stream newfile, string postfix, string nameofmodel)
        {
            if (string.IsNullOrWhiteSpace(postfix) | string.IsNullOrWhiteSpace(nameofmodel)) throw new NullReferenceException("args was null");
            AwsActionResultModel model = new AwsActionResultModel() { resultUrlFromModel = null, isCorrect = false };
            // Ну то есть тут 3 операции Get later Delete later Put
            using (var client = new AmazonS3Client(configurationAws))
            {
                var conditionContinue = await Continue(client, baseBucket);
                if (!conditionContinue)
                {
                    return model;
                }
                var request = new GetObjectRequest()
                {
                    BucketName = baseBucket,
                    Key = postfix + "/" + nameofmodel
                };
                var resp = client.GetObjectAsync(request);
                resp.Wait();
                if (resp.Result.HttpStatusCode != HttpStatusCode.OK)
                {
                    return model;
                }
                var resp2 = DeleteModel(postfix, nameofmodel);
                resp2.Wait();
                if (!resp2.Result)
                {
                    return model;
                }
                model = await AddModel(newfile, postfix, nameofmodel);
                return model;
            }
        }
        private async Task<bool> Continue(AmazonS3Client client, string bucket, bool condition = true)
        {
            var bucketExist = await AmazonS3Util.DoesS3BucketExistV2Async(client, bucket);
            bool res = bucketExist & condition ? true : false;
            if (!res) throw new Exception();
            return res;
        }
        private async Task<string> GetUrl(AmazonS3Client client, string pathforfile)
        {
            var request = new ListObjectsV2Request()
            {
                BucketName = baseBucket,
                Prefix = pathforfile,
            };
            var resp = await client.ListObjectsV2Async(request);
            var fileurl = resp.S3Objects.Where(o => o.Key == pathforfile).Select(o =>
            {
                return client.GetPreSignedURL(new GetPreSignedUrlRequest() { BucketName = baseBucket, Expires = DateTime.MaxValue, Key = o.Key });
            }).SingleOrDefault();
            return fileurl ?? throw new Exception();

        }


    }
}
