using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_items_selling_forms.Admin
{
    public partial class AddGame : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        DataGridViewRow row;
        int id;
        public AddGame(DataGridViewSelectedRowCollection Datalist)
        {
            InitializeComponent();
            GenreBox.Items.AddRange(Queries.GenresQuery());
            PlatformBox.Items.AddRange(Queries.PlatformQuery());
            PublComboBox.Items.AddRange(Queries.PublQuery());
            RatingTitleComboBox.Items.AddRange(Queries.RatingTitleQuery());
            PublCountry.Items.AddRange(Queries.CountriesQuery());
            row = Datalist[0];
            id = -1;
        }
        public AddGame(int dev_id)
        {
            InitializeComponent();
            GenreBox.Items.AddRange(Queries.GenresQuery());
            PlatformBox.Items.AddRange(Queries.PlatformQuery());
            PublComboBox.Items.AddRange(Queries.PublQuery());
            RatingTitleComboBox.Items.AddRange(Queries.RatingTitleQuery());
            PublCountry.Items.AddRange(Queries.CountriesQuery());
            id = dev_id;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
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

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            string publtitle;
            Издатели publ;
            Возрастной_рейтинг agerating;
            if (id == -1) id = Convert.ToInt32(row.Cells[0].Value);
            Разработчики dev = entity.Разработчики.FirstOrDefault(a => a.Код_разработчика == id);

            if (GameTitleBox.Text != "" && GenreBox.Text != "" && PlatformBox.Text != "" &&
                (PublComboBox.Text != "" || PublBox.Text != "" && NewPubl.Checked != false && PublCountry.Text != "") &&
                Engine.Text != "" && DatetimeGameBox.Value != null &&
                (RatingTitleComboBox.Text != "" && AgeRatingComboBox.Text != "" ||
                RatingTitleBox.Text != "" && NewTitleRating.Checked != false && AgeRatingBox.Text != ""))
            {
                if (DatetimeGameBox.Value <= DateTime.Now && dev.Дата_основания <= DatetimeGameBox.Value)
                {                  
                    Жанры genre = entity.Жанры.FirstOrDefault(a => a.Жанр == GenreBox.Text);
                    Платформы platform = entity.Платформы.FirstOrDefault(a => a.Платформа == PlatformBox.Text);
                    Страны country = entity.Страны.FirstOrDefault(a => a.Страна == PublCountry.Text);

                    if (NewPubl.Checked == true)
                    {
                        publtitle = PublBox.Text;
                        publ = new Издатели
                        {
                            Страны = country,
                            Издатели = publtitle
                        };
                    }
                    else { publ = entity.Издатели.FirstOrDefault(a => a.Издатели == PublComboBox.Text); }

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
                        Игра = GameTitleBox.Text,
                        Жанры = genre,
                        Платформы = platform,
                        Движок = Engine.Text
                    };
                    game.Издатели.Add(publ);
                    game.Возрастной_рейтинг.Add(agerating);
                    dev.Игры.Add(game);
                    entity.SaveChanges();
                    Close();
                }
                else MessageBox.Show("Неправильно введены даты");
            }
            else MessageBox.Show("Не все поля заполнены");
        }
    }
}
