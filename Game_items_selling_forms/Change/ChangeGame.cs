using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_items_selling_forms.Change
{
    public partial class ChangeGame : Form
    {
        Game_items_tradingEnt entity = new Game_items_tradingEnt();
        int game_id;
        public ChangeGame(int id)
        {
            InitializeComponent();
            game_id = id;
            GenreBox.Items.AddRange(Queries.GenresQuery());
            PlatformBox.Items.AddRange(Queries.PlatformQuery());
            PublComboBox.Items.AddRange(Queries.PublQuery());
            RatingTitleComboBox.Items.AddRange(Queries.RatingTitleQuery());
            PublCountry.Items.AddRange(Queries.CountriesQuery());           
            Игры game = entity.Игры.FirstOrDefault(a => a.Код_игры == id);
            ShowGame(game);
            DatetimeGameBox.Value = game.Дата_создания;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeGameButton_Click(object sender, EventArgs e)
        {
            Игры game = entity.Игры.FirstOrDefault(a => a.Код_игры == game_id);
            if (GameTitleBox.Text != "") { game.Игра = GameTitleBox.Text; }
            if (GenreBox.Text != "")
            {
                Жанры genre = entity.Жанры.FirstOrDefault(a => a.Жанр == GenreBox.Text);
                game.Жанры = genre;
            }
            if (PlatformBox.Text != "")
            {
                Платформы plarform = entity.Платформы.FirstOrDefault(a => a.Платформа == PlatformBox.Text);
                game.Платформы = plarform;
            }
            if (NewPubl.Checked == true)
            {
                if (PublBox.Text != "" && PublCountry.Text != "")
                {
                    Страны country = entity.Страны.FirstOrDefault(a => a.Страна == PublCountry.Text);
                    Издатели publ = new Издатели
                    {
                        Издатели = PublBox.Text,
                        Страны = country
                    };
                    game.Издатели.Add(publ);
                }
                else MessageBox.Show("Новый издатель не добавлен, так как не все поля заполнены");
            }
            else
            {
                if (PublComboBox.Text != "")
                {
                    DataGridViewRow row = Database.SelectedRows[0];
                    if (row != null)
                    {
                        string publ_name = row.Cells[7].ToString();
                        Издатели publ = game.Издатели.FirstOrDefault(a => a.Издатели == publ_name);
                        game.Издатели.Remove(publ);
                    }
                    Издатели newpubl = entity.Издатели.FirstOrDefault(a => a.Издатели == PublComboBox.Text);
                    game.Издатели.Add(newpubl);                   
                }
            }
            if (Engine.Text != "") { game.Движок = Engine.Text; }
            if (DatetimeGameBox.Value < DateTime.Now)
                { game.Дата_создания = DatetimeGameBox.Value; }

            if (NewTitleRating.Checked == true)
            {
                if (RatingTitleBox.Text != "" && AgeRatingBox.Text != "")
                {                   
                    Возрастной_рейтинг rating = new Возрастной_рейтинг
                    {
                        Название_рейтинга = RatingTitleBox.Text,
                        Рейтинг = AgeRatingBox.Text
                    };
                    game.Возрастной_рейтинг.Add(rating);
                }
                else MessageBox.Show("Новый возрастной рейтинг не добавлен, так как не все поля заполнены");
            }
            else
            {
                if (RatingTitleComboBox.Text != "" && AgeRatingComboBox.Text != "")
                {
                    DataGridViewRow row = Database.SelectedRows[0];
                    if (row != null)
                    {
                        string rating_name = row.Cells[8].ToString();
                        string rating = row.Cells[9].ToString();
                        Возрастной_рейтинг r = game.Возрастной_рейтинг.FirstOrDefault(a => a.Название_рейтинга == rating_name && a.Рейтинг == rating);
                        game.Возрастной_рейтинг.Remove(r);
                    }
                    Возрастной_рейтинг newrating = entity.Возрастной_рейтинг.FirstOrDefault(a => a.Название_рейтинга == RatingTitleComboBox.Text && a.Рейтинг == AgeRatingComboBox.Text);
                    game.Возрастной_рейтинг.Add(newrating);

                }
            }
            entity.SaveChanges();
            Close();
        }
        private void ShowGame(Игры game)
        {
            Database.ColumnCount = 12;
            Database.ColumnHeadersVisible = true;

            Database.Columns[0].Name = "Код игры";
            Database.Columns[1].Name = "Название игры";
            Database.Columns[2].Name = "Движок";
            Database.Columns[3].Name = "Дата создания";
            Database.Columns[4].Name = "Платформа";
            Database.Columns[5].Name = "Разработчик";
            Database.Columns[6].Name = "Жанр";
            Database.Columns[7].Name = "Издатели";
            Database.Columns[8].Name = "Название рейтинга";
            Database.Columns[9].Name = "Рейтинг";
            Database.Columns[10].Name = "Кол-во игр";

                foreach (Издатели p in game.Издатели)
                {
                    foreach (Возрастной_рейтинг r in game.Возрастной_рейтинг)
                    {
                        Database.Rows.Add(
                        game.Код_игры,
                        game.Игра,
                        game.Движок,
                        game.Дата_создания,
                        game.Платформы.Платформа,
                        game.Разработчики.Разработчик,
                        game.Жанры.Жанр,
                        p.Издатели,
                        r.Название_рейтинга,
                        r.Рейтинг,
                        game.Предметы_из_игр.Count());                       
                    }
                }
            Database.Rows.Add();
        }
    }
}
