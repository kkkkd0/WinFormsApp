using BuisnessLogic.Models;
using BuisnessLogic.Services;
using Data.interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Interfaces;

namespace WinFormsApp
{
    public class InputMethods : IRadioInput, ITextInput, ICheckInput
    {
        private Control _Object {  get; set; }
        private ModuleLinkInfo _ModulePropertyOnUser { get; set; }
        private IUserModulesManager _UserModules {  get; set; }
        private int _Position {  get; set; }
        public InputMethods(Control control, ModuleLinkInfo modulePropertyOnUser, int position, IUserModulesManager manager)
        {
            _ModulePropertyOnUser = modulePropertyOnUser;
            _Object = control;
            _UserModules = manager;
            _Position = position;
        }
        public bool InputRadio(User user)
        {
            var task = ReturnTask(user)!;

            Panel panel = (_Object as Panel)!;
            List<RadioButton> radioButtons = new List<RadioButton>();
            foreach(var control in panel.Controls)
            {
                var rb = control as RadioButton;
                if (rb is null) throw new InvalidCastException();
                radioButtons.Add(rb);
            }
            var answerButton = radioButtons.Where(x => x.Checked).FirstOrDefault();
            if(answerButton is null) throw new NullReferenceException("Nothing answer");
            var answer = answerButton.Text;

            task.Content!.UserAnswer = answer;

            _UserModules.ChangeUserModuleTest(user.Email, task.TestModel.Name, task.TestModel);

            return task.Content!.CorrectAnswer!.ToLower() == answer.ToLower();
        }
        public bool InputText(User user)
        {
            var task = ReturnTask(user)!;

            TextBox textBox = (_Object as TextBox)!;

            task.Content.UserAnswer = textBox.Text;

            _UserModules.ChangeUserModuleTest(user.Email, task.TestModel.Name, task.TestModel);

            return task.Content.CorrectAnswer == textBox.Text;
        }
        public bool InputCheck(User user)
        {
            var task = ReturnTask(user)!;

            CheckedListBox list = (_Object as CheckedListBox)!;
            IList<string> answers = new List<string>();
            foreach(var item in list.Items)
            {
                var check = (item as CheckBox)!;
                if (check.Checked)
                {
                    answers.Add(check.Text);
                }
            }
            var answer = string.Join(",", answers);
            task.Content!.UserAnswer = answer;
            _UserModules.ChangeUserModuleTest(user.Email, task.TestModel.Name, task.TestModel);
            return task.Content.CorrectAnswer == answer;
        }
        private Assignment? ReturnTask(User user)
        {
            Assignment? task = null;
            var module = user.GetType().GetProperty(_ModulePropertyOnUser.tablename)!.GetValue(user);
            if (_ModulePropertyOnUser.tablename is nameof(user.TestModules))
            {
                var moduleTest = module as IEnumerable<TestModule>;
                var test = moduleTest!.Where(x => x.IsActive is true).SingleOrDefault();
                if (test is null) throw new NullReferenceException(nameof(test));
                task = test.Assignments![_Position];
            }
            if (_ModulePropertyOnUser.tablename is nameof(user.TheoriesModules))
            {
                var moduleTest = module as IEnumerable<TheoreticalModule>;
                var test = moduleTest!.Where(x => x.IsActive is true).SingleOrDefault();
                if (test is null) throw new NullReferenceException(nameof(test));
                task = test.Assignments![_Position];
            }
            return task;
        }


    }
}
