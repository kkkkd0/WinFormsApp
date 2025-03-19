using AutoMapper;
using BuisnesLogic.Service;
using BuisnesLogic.ServicesInterface;
using BuisnessLogic.Services.Managers;
using Data.DataBase;
using Data.interfaces;
using Data.Models;

using System.Text.RegularExpressions;
using WinFormsApp.Models;
using Group = Data.Models.Group;


namespace WinFormsApp.Views
{
    public partial class UserRegistration : Form
    {
        private IUserManager _UserManager { get; set; }
        private PasswordManager _PasswordManager { get; set; }

        public UserRegistration(Point? location = null)
        {

            InitializeComponent();

            AppDbContext database = DataBaseInit.GetAppDbContext();

            _UserManager = new UserManager(database);

            _PasswordManager = new PasswordManager();

            this.Location = location ?? new Point(0, 0);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputFIO.Text) |
                string.IsNullOrWhiteSpace(inputEmail.Text) |
                string.IsNullOrWhiteSpace(inputGroups.Text) |
                string.IsNullOrWhiteSpace(inputPassword.Text))
            {
                MessageBox.Show("Ошибка вы не ввели значение");
                return;
            }
            var data = inputFIO.Text.Split(" ");

            var password = _PasswordManager.Salt(inputPassword.Text, 8);
            try
            {
                _UserManager.Create(new Data.Models.User()
                {
                    Email = inputEmail.Text,
                    Surname = data[0],
                    Name = data[data.Length is 1 ? 0 : 1],
                    Patronymic = data[data.Length is 1 ? 0 : 1],
                    PasswordHash = password.hash,
                    Salt = password.salt,
                    Groups = new List<Group> { new Group() { Way = inputGroups.Text } }
                });
            }
            catch (Exception ex) when (ex.Message.Contains("user"))
            {
                MessageBox.Show(ex.Message);
                return;
            }
            var user = _UserManager.Get(inputEmail.Text);
            if (user is null)
            {
                MessageBox.Show("Попробуйте зарегистрироваться позже");
                return;
            }
            AccountForm accountForm = new AccountForm(MapToUserView(user), inputEmail.Text);
            Hide();
            accountForm.ShowDialog();
            Close();

        }
        public static UserViewModel MapToUserView(User user)
        {
            var mapper = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>()
                 .ForMember("Surname", opt => opt.MapFrom(o => o.Surname))
                 .ForMember("Group", opt => opt.MapFrom(src => string.Join("", src.Groups!.Select(x => x.Way + " "))))
                 .ForMember("Name", opt => opt.MapFrom(src => src.Name))
                 .ForMember("Patronymic", opt => opt.MapFrom(src => src.Patronymic))));
            var usermap = mapper.Map<UserViewModel>(user);
            return usermap;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form = new StartForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputPassword.UseSystemPasswordChar = checkBox1.Checked;
        }
    }
}
