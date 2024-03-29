﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_items_selling_forms;

namespace Game_items_selling_forms
{
    public class Queries
    {
        static Game_items_tradingEnt entity = new Game_items_tradingEnt();

        public static object[] CountriesQuery()
        {
            List<object> c = new List<object>();

            foreach (Страны country in entity.Страны)
            {
                c.Add(country.Страна);
            }
            c.Sort();
            return c.ToArray();
        }
        public static object[] CurrenciesQuery()
        {
            List<object> c = new List<object>();

            foreach (Валюты curr in entity.Валюты)
            {
                c.Add(curr.Валюта);
            }
            c.Sort();
            return c.ToArray();
        }
        public static object[] GenresQuery()
        {
            List<object> c = new List<object>();

            foreach (Жанры genre in entity.Жанры)
            {
                c.Add(genre.Жанр);
            }
            return c.ToArray();
        }
        public static object[] PlatformQuery()
        {
            List<object> c = new List<object>();

            foreach (Платформы platform in entity.Платформы)
            {
                c.Add(platform.Платформа);
            }
            return c.ToArray();
        }
        public static object[] PublQuery()
        {
            List<object> c = new List<object>();

            foreach (Издатели publ in entity.Издатели)
            {
                c.Add(publ.Издатели);
            }
            return c.ToArray();
        }
        public static object[] AgeRatingQuery()
        {
            List<object> c = new List<object>();

            foreach (Возрастной_рейтинг rating in entity.Возрастной_рейтинг)
            {
                c.Add(rating.Рейтинг);
            }
            return c.ToArray();
        }
        public static object[] RatingTitleQuery()
        {
            List<object> c = new List<object>();

            foreach (Возрастной_рейтинг rating in entity.Возрастной_рейтинг)
            {
                c.Add(rating.Название_рейтинга);
            }
            return c.ToArray();
        }
    }
}
