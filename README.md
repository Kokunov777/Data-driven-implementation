# Физическая модель данных оранжерейного хозяйства

| Таблица | Атрибут | Тип данных | Ограничения | Индекс |
|---------|---------|------------|-------------|---------|
| **Город** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_город_наименование |
| **Улица** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_улица_наименование |
| | Идентификатор_города | INTEGER | NOT NULL, FOREIGN KEY | FK → Город(Идентификатор) |
| **Банк** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_банк_наименование |
| | БИК | VARCHAR(9) | NOT NULL, UNIQUE | UK |
| **Должность** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL, UNIQUE | UK |
| **Подразделение** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_подразделение_наименование |
| **Категория_товара** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_категория_наименование |
| **Сорт** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_сорт_наименование |
| | Сезонность | VARCHAR(50) | NOT NULL | |
| **Торговая_точка** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Тип | ENUM('Магазин', 'Киоск') | NOT NULL | idx_торговая_точка_тип |
| | Наименование | VARCHAR(100) | NOT NULL | idx_торговая_точка_наименование |
| | График_работы | VARCHAR(100) | NOT NULL | |
| | Номер_дома | VARCHAR(10) | | |
| | Расположение | VARCHAR(255) | | |
| | Идентификатор_города | INTEGER | NOT NULL, FOREIGN KEY | FK → Город(Идентификатор) |
| | Идентификатор_улицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Улица(Идентификатор) |
| **Смена** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_начала | TIMESTAMP | NOT NULL | idx_смена_дата |
| | Дата_окончания | TIMESTAMP | NOT NULL | |
| | Идентификатор_торговой_точки | INTEGER | NOT NULL, FOREIGN KEY | FK → Торговая_точка(Идентификатор) |
| **Сотрудник** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Фамилия | VARCHAR(50) | NOT NULL | idx_сотрудник_фамилия |
| | Имя | VARCHAR(50) | NOT NULL | |
| | Отчество | VARCHAR(50) | NOT NULL | |
| | Пол | ENUM('М', 'Ж') | NOT NULL | |
| | Дата_рождения | DATE | NOT NULL | |
| | Трудовой_стаж | INTEGER | NOT NULL | |
| | Код_ОКПДТР | VARCHAR(10) | NOT NULL | |
| | Номер_дома | VARCHAR(10) | NOT NULL | |
| | Статус | ENUM('Работает', 'Уволен') | NOT NULL | idx_сотрудник_статус |
| | Идентификатор_должности | INTEGER | NOT NULL, FOREIGN KEY | FK → Должность(Идентификатор) |
| | Идентификатор_подразделения | INTEGER | NOT NULL, FOREIGN KEY | FK → Подразделение(Идентификатор) |
| | Идентификатор_города | INTEGER | NOT NULL, FOREIGN KEY | FK → Город(Идентификатор) |
| | Идентификатор_улицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Улица(Идентификатор) |
| **Товар** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_товар_наименование |
| | Тип | ENUM('Срезанный цветок', 'Горшочный цветок', 'Сопутствующий', 'Букет') | NOT NULL | idx_товар_тип |
| | Цена | DECIMAL(10,2) | NOT NULL | idx_товар_цена |
| | Срок_хранения | INTEGER | | |
| | Диаметр | INTEGER | | |
| | Возраст | INTEGER | | |
| | Состав | TEXT | | |
| | Символическое_значение | VARCHAR(255) | | |
| | Описание | TEXT | | |
| | Идентификатор_категории_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Категория_товара(Идентификатор) |
| | Идентификатор_сорта | INTEGER | FOREIGN KEY | FK → Сорт(Идентификатор) |
| **Оранжерея** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_оранжерея_наименование |
| **Теплица** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Номер | VARCHAR(20) | NOT NULL | idx_теплица_номер |
| | Площадь | DECIMAL(8,2) | NOT NULL | |
| | Идентификатор_оранжереи | INTEGER | NOT NULL, FOREIGN KEY | FK → Оранжерея(Идентификатор) |
| **План_севооборота** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Год | YEAR | NOT NULL | idx_план_год |
| | Дата_посадки | DATE | NOT NULL | |
| | Дата_окончания | DATE | NOT NULL | |
| | Статус | ENUM('Активен', 'Завершен', 'Пар') | NOT NULL | |
| | Идентификатор_теплицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Теплица(Идентификатор) |
| | Идентификатор_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Товар(Идентификатор) |
| **Работа** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_работа_наименование |
| | Описание | TEXT | | |
| **Расписание_работ** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата | DATE | NOT NULL | idx_расписание_дата |
| | Идентификатор_теплицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Теплица(Идентификатор) |
| | Идентификатор_работы | INTEGER | NOT NULL, FOREIGN KEY | FK → Работа(Идентификатор) |
| | Идентификатор_ответственного | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
| **Производитель** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_производитель_наименование |
| | Код_ОК_028_2012 | VARCHAR(10) | NOT NULL | |
| | Аббревиатура | VARCHAR(10) | NOT NULL | |
| | Номер_дома | VARCHAR(10) | NOT NULL | |
| | Телефон_отдела_сбыта | VARCHAR(20) | NOT NULL | |
| | Идентификатор_банка | INTEGER | NOT NULL, FOREIGN KEY | FK → Банк(Идентификатор) |
| | Идентификатор_города | INTEGER | NOT NULL, FOREIGN KEY | FK → Город(Идентификатор) |
| | Идентификатор_улицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Улица(Идентификатор) |
| **Техника** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_техника_наименование |
| | Дата_выпуска | DATE | NOT NULL | |
| | Дата_последнего_ремонта | DATE | | |
| | Дата_очередного_ремонта | DATE | | |
| | Состояние | ENUM('Исправен', 'Неисправен', 'В ремонте', 'Списан') | NOT NULL | idx_техника_состояние |
| | Идентификатор_производителя | INTEGER | NOT NULL, FOREIGN KEY | FK → Производитель(Идентификатор) |
| **Запчасть** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_запчасть_наименование |
| | Цена | DECIMAL(10,2) | NOT NULL | |
| | Количество_на_складе | INTEGER | NOT NULL DEFAULT 0 | idx_запчасть_количество |
| | Идентификатор_производителя | INTEGER | NOT NULL, FOREIGN KEY | FK → Производитель(Идентификатор) |
| **Дефектовочная_ведомость** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_составления | DATE | NOT NULL | idx_дефектовка_дата |
| | Описание_дефекта | TEXT | NOT NULL | |
| | Статус | ENUM('Открыта', 'В работе', 'Завершена') | NOT NULL | |
| | Идентификатор_техники | INTEGER | NOT NULL, FOREIGN KEY | FK → Техника(Идентификатор) |
| **Наряд_на_ремонт** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_выписки | DATE | NOT NULL | idx_наряд_ремонт_дата |
| | Статус | ENUM('Назначен', 'В работе', 'Выполнен') | NOT NULL | |
| | Идентификатор_дефектовочной_ведомости | INTEGER | NOT NULL, FOREIGN KEY | FK → Дефектовочная_ведомость(Идентификатор) |
| | Идентификатор_бригадира | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
| **Наряд_на_работу** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_выполнения | DATE | NOT NULL | idx_наряд_работа_дата |
| | Время_работы | TIME | NOT NULL | |
| | Норма | DECIMAL(10,2) | NOT NULL | |
| | Идентификатор_техники | INTEGER | NOT NULL, FOREIGN KEY | FK → Техника(Идентификатор) |
| | Идентификатор_сотрудника | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
| **Поставщик** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Наименование | VARCHAR(100) | NOT NULL | idx_поставщик_наименование |
| | Код_органов | VARCHAR(10) | NOT NULL | |
| | ИНН | VARCHAR(12) | NOT NULL | |
| | БИН | VARCHAR(15) | NOT NULL | |
| | Телефон_отдела_сбыта | VARCHAR(20) | NOT NULL | |
| | Расчетный_счет | VARCHAR(20) | NOT NULL | |
| | Корреспондентский_счет | VARCHAR(20) | NOT NULL | |
| | Идентификатор_банка | INTEGER | NOT NULL, FOREIGN KEY | FK → Банк(Идентификатор) |
| | Идентификатор_города | INTEGER | NOT NULL, FOREIGN KEY | FK → Город(Идентификатор) |
| | Идентификатор_улицы | INTEGER | NOT NULL, FOREIGN KEY | FK → Улица(Идентификатор) |
| **Договор_поставки** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Номер | VARCHAR(20) | NOT NULL | idx_договор_номер |
| | Дата_заключения | DATE | NOT NULL | idx_договор_дата |
| | Срок_действия | VARCHAR(50) | NOT NULL | |
| | Идентификатор_поставщика | INTEGER | NOT NULL, FOREIGN KEY | FK → Поставщик(Идентификатор) |
| **Поставка** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Количество | INTEGER | NOT NULL | |
| | Дата_поставки | DATE | NOT NULL | idx_поставка_дата |
| | Идентификатор_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Товар(Идентификатор) |
| | Идентификатор_поставщика | INTEGER | NOT NULL, FOREIGN KEY | FK → Поставщик(Идентификатор) |
| **Посадочный_материал** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Тип | VARCHAR(50) | NOT NULL | |
| | Дата_закупки | DATE | NOT NULL | idx_посадочный_материал_дата |
| | Количество | INTEGER | NOT NULL | |
| | Идентификатор_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Товар(Идентификатор) |
| | Идентификатор_поставщика | INTEGER | NOT NULL, FOREIGN KEY | FK → Поставщик(Идентификатор) |
| **Смена_Сотрудник** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Роль | ENUM('Старший', 'Продавец') | NOT NULL | |
| | Идентификатор_смены | INTEGER | NOT NULL, FOREIGN KEY | FK → Смена(Идентификатор) |
| | Идентификатор_сотрудника | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
| **Отчет_о_продажах** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Сумма_выручки | DECIMAL(10,2) | NOT NULL | idx_отчет_сумма |
| | Дата_формирования_отчета | DATE | NOT NULL | idx_отчет_дата |
| | Количество | INTEGER | NOT NULL | |
| | Идентификатор_смены | INTEGER | NOT NULL, FOREIGN KEY | FK → Смена(Идентификатор) |
| **Списание_продукции** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Количество | INTEGER | NOT NULL | |
| | Причина | TEXT | NOT NULL | |
| | Дата_списания | DATE | NOT NULL | idx_списание_дата |
| | Идентификатор_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Товар(Идентификатор) |
| **Заявка_пополнения_ассортимента** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Необходимое_количество | INTEGER | NOT NULL | |
| | Дата_заявки | DATE | NOT NULL | idx_заявка_дата |
| | Статус | ENUM('Новая', 'В обработке', 'Выполнена') | NOT NULL | idx_заявка_статус |
| | Идентификатор_торговой_точки | INTEGER | NOT NULL, FOREIGN KEY | FK → Торговая_точка(Идентификатор) |
| | Идентификатор_товара | INTEGER | NOT NULL, FOREIGN KEY | FK → Товар(Идентификатор) |
| **Запись_трудовой_книжки** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_приема | DATE | | |
| | Дата_увольнения | DATE | | |
| | Дата_перевода | DATE | | |
| | Причина_прекращения_трудового_договора | VARCHAR(255) | | |
| | Идентификатор_сотрудника | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
| **Больничный_лист** | Идентификатор | SERIAL | PRIMARY KEY | PK |
| | Дата_начала | DATE | NOT NULL | idx_больничный_дата_начала |
| | Дата_окончания | DATE | NOT NULL | |
| | Номер | VARCHAR(20) | NOT NULL | |
| | Диагноз | VARCHAR(255) | NOT NULL | |
| | Идентификатор_сотрудника | INTEGER | NOT NULL, FOREIGN KEY | FK → Сотрудник(Идентификатор) |
