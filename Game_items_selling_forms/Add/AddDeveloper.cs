using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_items_selling_forms;

namespace Game_items_selling_forms.Admin
{
    public partial class AddDeveloper : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        bool reg;
        public AddDeveloper(string regis)
        {
            InitializeComponent();
            GenreBox.Items.AddRange(Queries.GenresQuery());
            PlatformBox.Items.AddRange(Queries.PlatformQuery());
            PublComboBox.Items.AddRange(Queries.PublQuery());
            RatingTitleComboBox.Items.AddRange(Queries.RatingTitleQuery());
            PublCountry.Items.AddRange(Queries.CountriesQuery());
            if (regis == "r") reg = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddDeveloperButton_Click(object sender, EventArgs e)
        {
            string publtitle;
            Издатель publ;
            Возрастной_рейтинг agerating;

            if (TitleBox.Text != "" && DatetimeBox.Value != null && EmpCount.Value >= 0 &&
                GameTitleBox.Text != "" && GenreBox.Text != "" && PlatformBox.Text != "" &&
                (PublComboBox.Text != "" || PublBox.Text != "" && NewPubl.Checked != false && PublCountry.Text != "") &&
                Engine.Text != "" && DatetimeGameBox.Value != null &&
                (RatingTitleComboBox.Text != "" &&  AgeRatingComboBox.Text != "" || 
                RatingTitleBox.Text != "" && NewTitleRating.Checked != false && AgeRatingBox.Text != ""))
            {
                if (DatetimeBox.Value <= DateTime.Now && DatetimeGameBox.Value <= DateTime.Now && DatetimeBox.Value <= DatetimeGameBox.Value)
                {
                    Разработчики developer = new Разработчики
                    {
                        Дата_основания = DatetimeBox.Value,
                        Название = TitleBox.Text,
                        Кол_во_сотрудников = (int)EmpCount.Value,
                    };

                    Жанры genre = entity.Жанры.FirstOrDefault(a => a.Название == GenreBox.Text);
                    Платформы platform = entity.Платформы.FirstOrDefault(a => a.Название == PlatformBox.Text);
                    Страны country = entity.Страны.FirstOrDefault(a => a.Название == PublCountry.Text);

                    if (NewPubl.Checked == true)
                    {
                        publtitle = PublBox.Text;
                        publ = new Издатель
                        {
                            Страны = country,
                            Название = publtitle
                        };
                    }
                    else { publ = entity.Издатель.FirstOrDefault(a => a.Название == PublComboBox.Text); }

                    if (NewTitleRating.Checked == true)
                    {
                        agerating = new Возрастной_рейтинг
                        {
                            Название_рейтинга = RatingTitleBox.Text,
                            Рейтинг = AgeRatingBox.Text
                        };
                    }
                    else { agerating = entity.Возрастной_рейтинг.FirstOrDefault(a => a.Название_рейтинга == RatingTitleComboBox.Text && a.Рейтинг == AgeRatingComboBox.Text); }
                    Игры game = new Игры
                    {
                        Дата_создания = DatetimeGameBox.Value,
                        Название = GameTitleBox.Text,
                        Жанры = genre,
                        Платформы = platform,
                        Движок = Engine.Text
                    };
                    game.Издатель.Add(publ);
                    game.Возрастной_рейтинг.Add(agerating);
                    developer.Игры.Add(game);
                    entity.Разработчики.Add(developer);
                    entity.SaveChanges();
                    if (reg == true)
                    {
                        string login = developer.Код_разработчика.ToString() + "_" + developer.Название.ToString();
                        string password = "developer";
                        MessageBox.Show($"Запомните следующие данные!\nВаш логин: {login}\nВаш пароль: {password}");
                    }
                    Close();
                }
                else MessageBox.Show("Неправильно введены даты");
            }
            else MessageBox.Show("Не все поля заполнены");
        }

        private void RatingTitleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            AgeRatingComboBox.Items.Clear();
            List<object> agerating = new List<object>();
            agerating.AddRange(entity.Возрастной_рейтинг.Where(a => a.Название_рейтинга == RatingTitleComboBox.Text));

            if (agerating != null)
            {
                foreach (Возрастной_рейтинг rating in agerating)
                {
                    AgeRatingComboBox.Items.Add(rating.Рейтинг);
                }
            }
        }

        private void NewPubl_CheckedChanged(object sender, EventArgs e)
        {
            if (NewPubl.Checked == true)
            { PublBox.Enabled = true; PublCountry.Enabled = true; }
            else { PublCountry.Enabled = false; PublBox.Enabled = false; }
        }

        private void NewTitleRating_CheckedChanged(object sender, EventArgs e)
        {
            if (NewTitleRating.Checked == true)
            { RatingTitleBox.Enabled = true; AgeRatingBox.Enabled = true; }
            else { RatingTitleBox.Enabled = false; AgeRatingBox.Enabled = false; }
        }
    }
}
