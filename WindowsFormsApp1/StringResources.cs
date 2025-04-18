using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class StringResources
    {
        internal static string LoginFormInvalidCredentialsMessage;
        internal static string LoginFormErrorMessageTitle;

        // История компании
        public static string CompanyHistory => "История компании СтальСтройГрупп Основание (1995 г.)\n" +
                                              "Компания СтальСтройГрупп была основана в 1995 году инженером-строителем Игорем \n" +
                                              "Владимировичем Ковалевым. Начав с небольших проектов по ремонту жилых домов, компания \n" +
                                              "быстро зарекомендовала себя как надежный подрядчик. Первым крупным заказом стало \n" +
                                              "строительство моста через реку Серебрянка, который до сих пор остается символом начала \n" +
                                              "пути компании.";

        // Структура персонала
        public static string EmployeeStructure => "Структура персонала (2024 г.)\n\n\n" +
                                                 "Руководство 15 Директор, замдиректора, начальники отделов \n\n" +
                                                 "Инженеры 120 Проектировщики, строители, BIM-менеджеры\n\n" +
                                                 "Администрация 50 HR, бухгалтерия, юристы, IT-специалисты\n\n" +
                                                 "Рабочие 300+ Мастера, монтажники, электрики, водители\n\n" +
                                                 "Охрана труда 10 Инспекторы по безопасности";

        // Приказ о приеме
        public static string HiringOrder => "Приказ о приеме на работу\n\n\n" +
                                            "О приеме на работу инженера-проектировщика\n " +
                                            "На основании трудового договора № 124 от 14.04.2024:\n" +
                                            "Принять Сергееву Елену Дмитриевну на должность инженера-проектировщика с 16.04.2024.\n" +
                                            "Установить испытательный срок — 3 месяца\n " +
                                            "Назначить наставника — Петрова А.К. (ведущий инженер).\n\n" +
                                            "Основание: Заявление сотрудника, резюме, приказ по личному составу.";

        // Документы (общий)
        public static string DocumentData => "Данные где живет житель";

        // Справочники - Отделы
        public static string DepartmentsInfo => "Кабинеты жителей";

        // Справочники - Города
        public static string CitiesInfo => "Город ангелов";

        // Справочники - Должности
        public static string PositionsInfo => "🔧 **Как создать приказ:**\n\n" +
                                             "1. Откройте меню \"Документы\" → \"Приказы\"\n" +
                                             "2. Выберите тип приказа (шаблон заполнится автоматически)\n" +
                                             "3. Внесите данные: - ФИО сотрудника  - Даты/суммы (для премий) - Основание\n" +
                                             "4. Нажмите \"Подписать и сохранить\"";

        // Окно (общее)
        public static string WindowInfo => "Тут ничего интересного";

        // Справка - Оглавление
        public static string ContentsInfo => "Найти нужный раздел без поиска по всему меню.\n\n" +
                                             "Ориентироваться в функционале программы.\n" +
                                             "Перейти к инструкциям по конкретным задачам (например, \"Как создать приказ?\").";

        // Справка - О программе
        public static string AboutProgramInfo => "🔹 Название: АИС \"Отдел кадров\" (Автоматизированная Информационная Система)\n" +
                                                  "🔹 Версия: 1.0.0.0\n" +
                                                  "🔹 Разработчик: IT-отдел компании \"СтальСтройГрупп\"\n" +
                                                  "🔹 Год выпуска: 2024\n" +
                                                  "🔹 Лицензия: Корпоративная (действует до 31.12.2025)";

        // Текст для button1
        public static string Button1Text => "Перейти на вторую форму";


        //Тексты кнопок меню:
        public static string RaznoeToolStripMenuItemText => "Разное";
        public static string SotrudnikiToolStripMenuItemText => "Сотрудники";
        public static string PrikazyToolStripMenuItemText => "Приказы";
        public static string DokumentyToolStripMenuItemText => "Документы";
        public static string SpravochnikiToolStripMenuItemText => "Справочники";
        public static string OtdelyToolStripMenuItemText => "Отделы";
        public static string GorodaToolStripMenuItemText => "Города";
        public static string DolzhnostiToolStripMenuItemText => "Должности";
        public static string OknoToolStripMenuItemText => "Окно";
        public static string SpravkaToolStripMenuItemText => "Справка";
        public static string OglavlenieToolStripMenuItemText => "Оглавление";
        public static string OPrograToolStripMenuItemText => "О программе";
    }
}
