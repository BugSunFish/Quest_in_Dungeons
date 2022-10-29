using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_7_game
{
    internal class Program 
    {
        
        static void Main(string[] args)
        {
            //Выключение курсора
            Console.CursorVisible = false;
            //Рандомайзер
            Random random = new Random();
            //Размер поля
            string[,] zone = new string[9, 16];
            //Комнаты
            Rooms room = new Rooms();
            void Room0(string[,] zone, int i, int j)
            {
                room.Room0(zone, i, j);
            }
            void Room1(string[,] zone, int i, int j)
            {
                room.Room1(zone, i, j);
            }
            void Room2(string[,] zone, int i, int j)
            {
                room.Room2(zone, i, j);
            }
            void Room3(string[,] zone, int i, int j)
            {
                room.Room3(zone, i, j);
            }
            void Room4d(string[,] zone, int i, int j)
            {
                room.Room4d(zone, i, j);
            }
            void Room4(string[,] zone, int i, int j)
            {
                room.Room4(zone, i, j);
            }
            void Room5(string[,] zone, int i, int j)
            {
                room.Room5(zone, i, j);
            }
            void Room6(string[,] zone, int i, int j)
            {
                room.Room6(zone, i, j);
            }
            void Room7(string[,] zone, int i, int j)
            {
                room.Room7(zone, i, j);
            }
            void Room8(string[,] zone, int i, int j)
            {
                room.Room8(zone, i, j);
            }
            void Room9(string[,] zone, int i, int j)
            {
                room.Room9(zone, i, j);
            }
            void Room10(string[,] zone, int i, int j)
            {
                room.Room10(zone, i, j);
            }
            void Room11(string[,] zone, int i, int j)
            {
                room.Room11(zone, i, j);
            }
            void Room12(string[,] zone, int i, int j)
            {
                room.Room12(zone, i, j);
            }
            void Room13(string[,] zone, int i, int j)
            {
                room.Room13(zone, i, j);
            }
            void Room14(string[,] zone, int i, int j)
            {
                room.Room14(zone, i, j);
            }
            void Room15(string[,] zone, int i, int j)
            {
                room.Room15(zone, i, j);
            }
            //Настройки врага
            int ye = 4, xe = 6;
            int hpe = 10;
            int mpe = 0;
            int pwe = 2;
            int runtime = 0;
            bool dir = false;
            void Enemy(int i, int j)
            {
                if (i==ye && j==xe) {
                    zone[i, j] = " x";
                }
            }
            //Игрок
            int hp = 20;
            int maxhp = 20;
            int mp = 10;
            int pw = 2;
            int money = 12;
            bool hat = false;
            //Спавн игрока
            int y = 5, x = 7;
            //int y = 5, x = 7;
            //Буфер
            int yb = y, xb = x;
            int ybe = ye, xbe = xe;
            //Номер локации
            int loc = 0;
            //Состояние диалога
            bool ms = false;
            //Готовность к диалогу
            bool gm = false;
            //Меч
            bool sw = false;
            //Сумка
            bool bag = false;
            //Амулет
            bool amulet = false;
            //Зелье
            int potion = 0;
            //Броня
            bool ironHat = false;
            bool ironBib = false;
            bool ironBoots = false;
            //Диалог с магом
            bool mWizard = false;
            //Наличие квеста
            bool qst = false;
            //Комментарий торговца
            bool tk = false;
            //Дверь в подземелье
            bool dd = false;
            //Люк
            bool trapdoor = false;
            //Место диалога
            int locms = 0;
            //Номер диалога
            int nms = 0;
            //Тёмная сцена
            bool dc = false;
            //Первая встреча с личом
            bool mlc = false;
            //Возможность ходить
            bool run = true;
            //Диалог с могильщиком об дереве
            bool mtrees = false;
            bool mtrees_end = false;
            //Квест от Бармена
            bool quest_thanks = false;
            bool quest_thanks_end = false;
            //Квест от Дворфа
            bool quest_beer = false;
            bool quest_beer_info = false;
            bool quest_beer_end = false;
            int Wheat = 0;
            //Пшеница
            bool w1 = false;
            bool w2 = false;
            bool w3 = false;
            bool w4 = false;
            bool w5 = false;
            bool w6 = false;
            bool w7 = false;
            bool w8 = false;
            //Пивная дуэль
            bool win = false;
            bool d_win = false;
            //Секретный проход
            bool secret_door = true;
            void sDoor(int i, int j)
            {
                if (i == 0 && j == 7)
                {
                    zone[i, j] = "__";
                }
            }

            while (true)
            {
                //Переход между локациями
                switch (y, x, loc)
                {
                    case ( >= 4 and <= 6, 16, 0):
                        loc = 1;
                        x -= 15;
                        break;
                    case (-1, >= 7 and <= 9, 1):
                        loc = 2;
                        y += 8;
                        break;
                    case (9, >= 7 and <= 9, 2):
                        loc = 1;
                        y -= 8;
                        break;
                    case ( >= 3 and <= 5, -1, 2):
                        loc = 3;
                        x += 15;
                        break;
                    case ( >= 3 and <= 5, 16, 6):
                        loc = 7;
                        x -= 15;
                        break;
                    case ( >= 3 and <= 5, -1, 7):
                        loc = 6;
                        x += 15;
                        break;
                    case ( 9, >= 6 and <= 8, 7):
                        loc = 8;
                        y -= 8;
                        break;
                    case (-1, >= 6 and <= 8, 8):
                        loc = 7;
                        y += 8;
                        break;
                    case ( >= 5 and <= 7, 16, 8):
                        loc = 9;
                        x -= 15;
                        break;
                    case ( >= 5 and <= 7, -1, 9):
                        loc = 8;
                        x += 15;
                        break;
                    case ( >= 5 and <= 7, 16, 9):
                        loc = 10;
                        x -= 15;
                        break;
                    case ( >= 5 and <= 7, -1, 10):
                        loc = 9;
                        x += 15;
                        break;
                    case (-1, >= 7 and <= 8, 10):
                        loc = 11;
                        y += 8;
                        break;
                    case (9, >= 7 and <= 8, 11):
                        loc = 10;
                        y -= 8;
                        break;
                    case (6, >= 7 and <= 8, 13):
                        loc = 12;
                        break;
                    case (5, >= 7 and <= 8, 12):
                        loc = 13;
                        break;
                    case (1, >= 1 and <= 2, 12):
                        loc = 11;
                        y += 2;
                        break;
                    case (1, >= 1 and <= 2, 11):
                        loc = 12;
                        y += 2;
                        break;
                    case (-1, >= 2 and <= 13, 14):
                        loc = 10;
                        y += 8;
                        break;
                    case (9, >= 2 and <= 13, 10):
                        loc = 14;
                        y -= 8;
                        break;
                    case (>= 5 and <= 7, -1, 15):
                        loc = 10;
                        x += 15;
                        break;
                    case ( >= 5 and <= 7, 16, 10):
                        loc = 15;
                        x -= 15;
                        hpe = 10;
                        ye = 5;
                        xe = 14;
                        break;
                }
                switch (trapdoor, loc, mlc)
                {
                    case (true, 3, false):
                        loc = 4;
                        yb = 4;
                        xb = 3;
                        y = 4;
                        x = 3;
                        break;
                    case (true, 4, true):
                        loc = 5;
                        break;
                }

                //Проверка на препятствия
                if (dir = true && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                {
                    ye = ybe;
                    xe = xbe;
                    ye++;
                    if (dir = true && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                    {
                        ye = ybe;
                        xe = xbe;
                        ye--;
                    }
                }
                if (dir = false && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                {
                    ye = ybe;
                    xe = xbe;
                    xe++;
                    if (dir = false && (zone[ye, xe] == " #" || zone[ye, xe] == " |" || zone[ye, xe] == "__" || zone[ye, xe] == "| " || zone[ye, xe] == "[]" || zone[ye, xe] == " X"))
                    {
                        ye = ybe;
                        xe = xbe;
                        xe--;
                    }
                }
                if (zone[y, x] == " #" || zone[y, x] == " |" || zone[y, x] == "__" || zone[y, x] == "| " || zone[y, x] == "* " || zone[y, x] == " ?" || zone[y, x] == " Y" || zone[y, x] == " w" || zone[y, x] == "[]" || zone[y, x] == "ї`" || zone[y, x] == "i " || zone[y, x] == " X" || zone[y, x] == " L" || zone[y, x] == " т" || zone[y, x] == " g" || zone[y, x] == "=|" || zone[y, x] == "==" || zone[y, x] == " P" || zone[y, x] == ".," || zone[y, x] == "~~" || zone[y, x] == " W")
                {
                    y = yb;
                    x = xb;
                }
                
                //Бой
                if (y==ye && x==xe && runtime==0 && hpe > 0 && (loc==3 || loc ==15)) 
                {
                    int menu = 1;
                    int menu2 = 0;
                    while(true)
                    {
                        Console.Clear();
                        Console.WriteLine($"\t\tFight\n\tYou\t\t  Enemy");
                        Console.WriteLine($"       HP {hp}\t\t  HP {hpe}");
                        Console.WriteLine($"       MP {mp}\t\t  MP {mpe}");
                        Console.WriteLine($"       PW {pw}\t\t  PW {pwe}\n");
                        switch (menu,menu2)
                        {
                            case (1,0):
                                Console.WriteLine("   <Атака>\tИнвентарь\tСбежать");
                                break;
                            case (2,0):
                                Console.WriteLine("   Атака\t<Инвентарь>\tСбежать");
                                break;
                            case (3,0):
                                Console.WriteLine("   Атака\tИнвентарь\t<Сбежать>");
                                break;
                            case (1,1):
                                Console.Write("   <Назад>\t");
                                if (sw==true)
                                {
                                    Console.Write("Меч\t");
                                }
                                Console.Write("Игнорировать");
                                break;
                            case (2,1):
                                Console.Write("   Назад\t");
                                if (sw == true)
                                {
                                    Console.Write("<Меч>\t");
                                }
                                Console.Write("Игнорировать");
                                break;
                            case (3, 1):
                                Console.Write("   Назад\t");
                                if (sw == true)
                                {
                                    Console.Write("Меч\t");
                                }
                                Console.Write("<Игнорировать>");
                                break;
                            case (1, 2):
                                Console.Write("   <Назад>\t");
                                if (potion > 0)
                                {
                                    Console.Write($"Зелье {potion}\t");
                                }
                                break;
                            case (2, 2):
                                Console.Write("   Назад\t");
                                if (potion > 0)
                                {
                                    Console.Write($"<Зелье {potion}>\t");
                                }
                                break;
                        }
                        Console.WriteLine($"");
                        ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                        switch (consoleKey.Key)
                        {
                            case ConsoleKey.D:
                                menu++;
                                break;
                            case ConsoleKey.A:
                                menu--;
                                break;
                            case ConsoleKey.F:
                                switch(menu,menu2)
                                {
                                    case (1,0):
                                        menu2 = 1;
                                        break;
                                    case (2, 0):
                                        menu = 1;
                                        menu2 = 2;
                                        break;
                                    case (3, 0):
                                        if (random.Next(3) == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n\n\t\tВы сбежали\n\n\n\n");
                                            runtime = 3;
                                            Console.ReadKey(true);
                                        } else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n\n\t\tВам не удалось сбежать\n\tНажмите любую клавишу для продолжения\n\n\n");
                                            hp -= pwe;
                                            Console.ReadKey(true);
                                        }
                                        break;
                                    case (1, 1):
                                        menu2 = 0;
                                        break;
                                    case (2, 1):
                                        menu = 1;
                                        menu2 = 0;
                                        hp -= pwe;
                                        hpe -= pw;
                                        break;
                                    case (3, 1):
                                        menu = 1;
                                        menu2 = 0;
                                        hp -= pwe;
                                        break;
                                    case (1, 2):
                                        menu = 2;
                                        menu2 = 0;
                                        break;
                                    case (2, 2):
                                        menu = 2;
                                        menu2 = 0;
                                        potion--;
                                        hp += 20;
                                        if (hp > maxhp)
                                        {
                                            hp = maxhp;
                                        }
                                        break;
                                }
                                break;
                            default:
                                break;
                        }
                        if (menu == 4 && menu2 == 0)
                        {
                            menu--;
                        }
                        if (menu == 4 && menu2 == 1)
                        {
                            menu--;
                        }
                        if (menu == 3 && menu2 == 2)
                        {
                            menu--;
                        }
                        if (menu == 0)
                        {
                            menu++;
                        }
                        if (runtime > 0 || hp <= 0 || hpe <=0)
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    if (hp <= 0)
                    {
                        Console.WriteLine("\n\n\n\n\n\t\tМонстр вас вырубил\n\n\n\n");
                        Console.ReadKey(true);
                    }
                    if (hpe <= 0)
                    {
                        int reward = (10 + random.Next(5));
                        money += reward;
                        Console.WriteLine($"\n\n\n\n\n\t\tВы одолели монстра!\n\t\tЗолото +{reward}\n\n\n");
                        Console.ReadKey(true);
                    }
                    
                    Console.Clear();
                }

                //Перезапись буфера
                yb = y;
                xb = x;
                gm = false;
                ybe = ye;
                xbe = xe;

                //Создание поля / get
                for (int i = 0; i < zone.GetUpperBound(0) + 1/* y */; i++)
                {
                    for (int j = 0; j < zone.GetUpperBound(1) + 1/* x */; j++)
                    {
                        if (y < zone.GetUpperBound(0) + 1 && x < zone.GetUpperBound(1) + 1) // Игрок
                        {
                            zone[y, x] = " @";
                        }
                        zone[i, j] = "  ";
                    }
                }

                //Заполнение поля / set
                for (int i = 0; i < zone.GetUpperBound(0) + 1 /* y */; i++)
                {
                    for (int j = 0; j < zone.GetUpperBound(1) + 1/* x */; j++)
                    {
                        switch (dd, loc, i, j)
                        {
                            case (false, 2, >= 3 and <= 5, 0):
                                zone[i, j] = " #";
                                break;
                        }
                        if (hpe > 0)
                        {
                            switch (loc)
                            {
                                case 15:
                                case 3:
                                    Enemy(i, j);
                                    break;
                            }
                        }
                        if (secret_door == true)
                        {
                            switch (loc)
                            {
                                case 15:
                                    sDoor(i, j);
                                    break;
                            }
                        }
                        switch (loc)
                        {
                            case 0:
                                Room0(zone,i, j);
                                break;
                            case 1:
                                Room1(zone, i, j);
                                break;
                            case 2:
                                Room2(zone, i, j);
                                break;
                            case 3:
                                Room3(zone, i, j);
                                break;
                            case 4:
                                if (dc == false)
                                {
                                    Room4d(zone, i, j);
                                } 
                                else
                                {
                                    Room4(zone, i, j);
                                }
                                break;
                            case 5:
                                Room5(zone, i, j);
                                break;
                            case 6:
                                Room6(zone, i, j);
                                break;
                            case 7:
                                Room7(zone, i, j);
                                break;
                            case 8:
                                Room8(zone, i, j);
                                break;
                            case 9:
                                Room9(zone, i, j);
                                break;
                            case 10:
                                Room10(zone, i, j);
                                break;
                            case 11:
                                Room11(zone, i, j);
                                break;
                            case 12:
                                Room12(zone, i, j);
                                break;
                            case 13:
                                Room13(zone, i, j);
                                break;
                            case 14:
                                Room14(zone, i, j);
                                break;
                            case 15:
                                Room15(zone, i, j);
                                break;
                        }
                        
                    }
                    Console.WriteLine("");
                }

                //Зона действия
                switch (y, x, ms, loc, nms, mlc)
                {
                    case (4, 3, false, 4, 0, false):
                        gm = true;
                        locms = 4;
                        break;
                    case (4, 3, false, 5, 0, true):
                        Console.WriteLine(".........: F");
                        gm = true;
                        locms = 5;
                        break;
                }
                if(dc == false && loc == 4d)
                {
                    Console.WriteLine("Вокруг очень темно, рядом стоит факел.\nЗажечь?: F");
                    run = false;
                }
                switch (y, x, ms, loc)
                {
                    case ( >= 3 and <= 5, 2, false, 0):
                    case (4, >= 1 and <= 3, false, 0):
                        locms = 0;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case (8, >= 2 and <= 12, false, 0):
                        Console.WriteLine("Я не могу вернуться в деревню без потерянного меча. \nМне уже заплатили.");
                        break;
                    case ( >= 4 and <= 6, 12, false, 1):
                    case (5, >= 11 and <= 13, false, 1):
                        locms = 1;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case ( >= 4 and <= 6, 1, false, 1):
                        locms = 2;
                        Console.WriteLine("Осмотреть: F");
                        gm = true;
                        break;
                    case ( >= 3 and <= 5, 8, false, 2):
                    case (4, >= 7 and <= 9, false, 2):
                        locms = 3;
                        if (dd == true)
                        {
                            Console.WriteLine("Я должен одолеть лича и помочь этому парню выбраться.");
                        }
                        else
                        {
                            Console.WriteLine("Человек закутанный в одеяло с потрёпанной шляпой на голове.\nСмахивает на торговца.");
                        }
                        Console.WriteLine("Поговорить: F");
                        gm = true;
                        break;
                    case (4, >= 2 and <= 4, false, 3):
                    case ( >= 3 and <= 5, 3, false, 3):
                        Console.WriteLine("Открытый ржавый люк\nСпуститься: F");
                        trapdoor = true;
                        break;
                    case (4, >= 8 and <= 10, false, 10):
                    case ( >= 3 and <= 5, 9, false, 10):
                        Console.WriteLine("К северу - Таверна WindPeak\nК югу - плантация\nК западу - кладбище\nК востоку - тайная тропа");
                        break;
                    case ( >= 4 and <= 6, 2, false, 8):
                    case ( 5, >= 1 and <= 3, false, 8):
                        Console.WriteLine("Дерево прорастающее потолок?");
                        break;
                    case (4, >= 3 and <= 5, false, 6):
                    case ( >= 3 and <= 5, 4, false, 6):
                        Console.WriteLine("*Факел горит ярким пламенем*\nИнтересно, что имел ввиду лич?");
                        break;
                    case (4, 6, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 6;
                        gm = true;
                        break;
                    case (6, 6, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 7;
                        gm = true;
                        break;
                    case (4, 8, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 8;
                        gm = true;
                        break;
                    case (6, 8, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 9;
                        gm = true;
                        break;
                    case (4, 10, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 10;
                        gm = true;
                        break;
                    case (6, 10, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 11;
                        gm = true;
                        break;
                    case (4, 12, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 12;
                        gm = true;
                        break;
                    case (6, 12, false, 8):
                        Console.WriteLine("Старая могила \nОсмотреть: F");
                        locms = 13;
                        gm = true;
                        break;
                    case (5, 4, false, 8):
                    case ( >= 4 and <= 6, 3, false, 8):
                        if (quest_thanks == true && quest_thanks_end == false && mtrees_end == true)
                        {
                            Console.WriteLine("Старик с лопатой\nПогворить: F");
                            locms = 16;
                            gm = true;
                        }
                        if (mtrees == false)
                        {
                            Console.WriteLine("Старик с лопатой\nПогворить: F");
                            locms = 14;
                            gm = true;
                        }
                        break;
                    case ( 3, 8, false, 11):
                        if (quest_thanks == false)
                        {
                            Console.WriteLine("Хозяин таверны\nПогворить: F");
                            locms = 15;
                            gm = true;
                        }
                        if (quest_beer == true && quest_beer_info == false && quest_thanks == true && Wheat == 0)
                        {
                            Console.WriteLine("Хозяин таверны\nПогворить: F");
                            locms = 20;
                            gm = true;
                        }
                        if (hp < 20 && quest_thanks == true && gm == false && Wheat !=8)
                        {
                            Console.WriteLine("Хозяин таверны\nПогворить: F");
                            locms = 17;
                            gm = true;
                        }
                        if (quest_beer_end == false && Wheat == 8)
                        {
                            Console.WriteLine("Хозяин таверны\nПогворить: F");
                            locms = 29;
                            gm = true;
                        }
                        if (hp==20 && amulet)
                        {
                            Console.WriteLine("Кстати, может что-то хотел бы приобрести? \nАссортимент не большой, но что есть: F");
                            locms = 34;
                            gm = true;
                        }
                        break;
                    case (7, 7, false, 14):
                        if (hp < maxhp)
                        {
                            Console.WriteLine("Вода в источнике чуть ли не светится.\nОтпить: F");
                            locms = 18;
                            gm = true;
                        }
                        break;
                    case (3, 10, false, 11):
                    case (4, >= 9 and <= 11, false, 11):
                        if (quest_beer == false)
                        {
                            Console.WriteLine("Дворф, спит с кружкой пива в руках, символично.\nПогворить: F");
                            locms = 19;
                            gm = true;
                        }
                        if (quest_beer_end == true && amulet == false)
                        {
                            Console.WriteLine("Большая бочка с пивом, а нет, это Дворф.\nПогворить: F");
                            locms = 30;
                            gm = true;
                        }
                        break;
                    case (3, 6, false, 14):
                    case (3, 4, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w1 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 21;
                            gm = true;
                        }
                        break;
                    case (5, 4, false, 14):
                    case (5, 6, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w2 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 22;
                            gm = true;
                        }
                        break;
                    case (6, 1, false, 14):
                    case (6, 3, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w3 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 23;
                            gm = true;
                        }
                        break;
                    case (5, 10, false, 14):
                    case (5, 8, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w4 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 24;
                            gm = true;
                        }
                        break;
                    case (6, 8, false, 14):
                    case (6, 10, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w5 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 25;
                            gm = true;
                        }
                        break;
                    case (4, 6, false, 14):
                    case (4, 4, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w6 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 26;
                            gm = true;
                        }
                        break;
                    case (6, 11, false, 14):
                    case (6, 13, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w7 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 27;
                            gm = true;
                        }
                        break;
                    case (4, 13, false, 14):
                    case (4, 11, false, 14):
                        if (quest_beer == true && Wheat < 8 && quest_beer_info == true && w8 == false)
                        {
                            Console.WriteLine("Пшеница.\nСрезать: F");
                            locms = 28;
                            gm = true;
                        }
                        break;
                    case (2, 4, false, 13):
                        Console.WriteLine("Мягкая кровать..\nНа сон нет времени.");
                        break;
                    case ( >= 5 and <= 7, 12, false, 11):
                    case (6, 13, false, 11):
                        Console.WriteLine("Дворф поменьше\nПогворить: F");
                        locms = 31;
                        gm = true;
                        break;
                    case ( >= 5 and <= 7, 3, false, 11):
                    case (6, 2, false, 11):
                        if (mWizard == false)
                        {
                            Console.WriteLine("Старичок в большой шляпе, с книгой на столе, может быть он маг?\nПогворить: F");
                            locms = 32;
                            gm = true;
                        }
                        if (amulet && mWizard)
                        {
                            Console.WriteLine("Старичок в большой шляпе, с книгой на столе, может быть он маг?\nПогворить: F");
                            locms = 33;
                            gm = true;
                        }
                        break;
                }

                //Текст бар
                switch (ms, sw, qst, tk, dd, locms)
                {
                    case (true, false, false, false, false, 0):
                        Console.WriteLine("Костёр согревает даже в самую холодную зиму...");
                        ms = false;
                        break;
                    case (true, false, true or false, true or false, true or false, 1):
                        Console.WriteLine("Среди листьев вы нашли меч!");
                        sw = true;
                        ms = false;
                        break;
                    case (true, true, true or false, true or false, true or false, 1):
                        Console.WriteLine("Тут больше ничего нет.");
                        ms = false;
                        break;
                    case (true, true or false, false, true or false, true or false, 2):
                        Console.WriteLine("О нет! Дверь закрылась снаружи. \nВряд ли её можно открыть отсюда..");
                        ms = false;
                        break;
                    case (true, true or false, true, true or false, true or false, 2):
                        Console.WriteLine("Я не смогу открыть эту дверь. \nНужно идти дальше.");
                        ms = false;
                        break;
                    case (true, true or false, false, false, false, 3):
                        Console.WriteLine("Mae govannen! Рад увидеть человека, хоть и жаль что в таком месте...\nТы как и я попал в ловушку лича. Живущего в конце этой пещеры.");
                        ms = false;
                        qst = true;
                        tk = true;
                        break;
                    case (true, true or false, true, true, false, 3):
                        Console.WriteLine("Я слишком слаб что бы сразить его.. \nНо если у тебя есть меч, я могу открыть проход для тебя.");
                        ms = false;
                        tk = false;
                        break;
                    case (true, true, true, false, false, 3):
                        Console.WriteLine("Вижу ты нашёл меч, я открою для тебя дверь..\nВ качестве благодарности пожалуйста возьми мою шляпу. Мой отец говорил она приносит удачу..");
                        ms = false;
                        dd = true;
                        hat = true;
                        break;
                    case (true, false, true, false, false, 3):
                        Console.WriteLine("Ты хочешь остаться со мной? Я был бы рад умереть не в одиночестве..");
                        ms = false;
                        break;
                    case (true, true, true, false, true, 3):
                        Console.WriteLine("Мне придётся закрыть за тобой дверь что-бы монстры не добрались сюда. \nПожалуйста береги себя..");
                        ms = false;
                        break;
                }
                switch (ms, locms, nms)
                {
                    case (true, 34, 0):
                        //Магазин
                        {
                            int mmenu = 1;
                            int m = 0;
                            bool buy = false;
                            bool exit = false;
                            int delay = 2;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("\t   Купить");
                                Console.WriteLine("\t============");
                                m = 0;
                                m++;
                                if (m == mmenu)
                                {
                                    Console.WriteLine($"\t> Зелья x{potion}\t7м");
                                }
                                else
                                {
                                    Console.WriteLine($"\t  Зелья x{potion}\t7м");
                                }
                                if (buy && m == mmenu && money >= 7)
                                {
                                    potion++;
                                    money -= 7;
                                }
                                if (ironHat == false)
                                {
                                    m++;
                                    if (m == mmenu)
                                    {
                                        Console.WriteLine($"\t> Шлем\t\t12м");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\t  Шлем\t\t12м");
                                    }
                                    if (buy && m == mmenu && money >= 12)
                                    {
                                        ironHat = true;
                                        maxhp += 10;
                                        money -= 12;
                                    }
                                }
                                if (ironBib == false)
                                {
                                    m++;
                                    if (m == mmenu)
                                    {
                                        Console.WriteLine($"\t> Кольчуга\t15м");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\t  Кольчуга\t15м");
                                    }
                                    if (buy && m == mmenu && money >= 15)
                                    {
                                        ironBib = true;
                                        maxhp += 12;
                                        money -= 15;
                                    }
                                }
                                if (ironBoots == false)
                                {
                                    m++;
                                    if (m == mmenu)
                                    {
                                        Console.WriteLine($"\t> Сапоги\t10м");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\t  Сапоги\t10м");
                                    }
                                    if (buy && m == mmenu && money >= 10)
                                    {
                                        ironBoots = true;
                                        maxhp += 8;
                                        money -= 10;
                                    }
                                }
                                Console.WriteLine("\t============");
                                Console.WriteLine($"\t  У вас {money}м\n\t  Выйти Tab");
                                buy = false;
                                if (delay > 0)
                                {
                                    delay--;
                                }
                                if (delay == 0)
                                {
                                    if (buy == false)
                                    {
                                        ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                                        switch (consoleKey.Key)
                                        {
                                            case ConsoleKey.S:
                                                mmenu++;
                                                break;
                                            case ConsoleKey.W:
                                                mmenu--;
                                                break;
                                            case ConsoleKey.F:
                                                buy = true;
                                                delay = 3;
                                                break;
                                            case ConsoleKey.Tab:
                                                exit = true;
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                if (mmenu > m)
                                {
                                    mmenu--;
                                }
                                if (mmenu < 1)
                                {
                                    mmenu++;
                                }
                                if (exit == true)
                                {
                                    break;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("\n\n\n\n\t\t  Возвращайся!\n\n\n\n");
                        }
                        run = true;
                        ms = false;
                        break;
                    case (true, 33, 0):
                        Console.WriteLine("Дивный амулет малой.");
                        ms = false;
                        break;
                    case (true, 32, 0):
                        Console.WriteLine("Приветствую, ты ведь тот малой которого старик притащил?");
                        nms++;
                        run = false;
                        break;
                    case (true, 32, 1):
                        Console.WriteLine("Знал бы ты сколько до тебя тут таких же безпомощных было.");
                        nms++;
                        break;
                    case (true, 32, 2):
                        Console.WriteLine("Хотя в сравнении с теми на тебе ни царапины..");
                        nms++;
                        break;
                    case (true, 32, 3):
                        Console.WriteLine("Кого удаётся спасти, старик всех тащит.");
                        nms++;
                        break;
                    case (true, 32, 4):
                        Console.WriteLine("Хочешь спросить почему я его стариком называю?");
                        nms++;
                        break;
                    case (true, 32, 5):
                        Console.WriteLine("При нашей первой встрече мне небыло и дюжины, а у него уже все волосы были седые.");
                        nms++;
                        break;
                    case (true, 32, 6):
                        Console.WriteLine("Говорят они c хозяином таверны попали в эту пещеру вместе с самим личом!");
                        nms++;
                        break;
                    case (true, 32, 7):
                        Console.WriteLine("Ещё говорят что эту таверну видели в нескольких подземельях разные авантюристы!");
                        nms++;
                        break;
                    case (true, 32, 8):
                        Console.WriteLine("На самом деле я многое видел, так что поверить в это могу.");
                        nms++;
                        break;
                    case (true, 32, 9):
                        Console.WriteLine("Я здесь что-бы проверить это, но все как на зло молчат об этом..\nА для старика больная тема..");
                        nms=0;
                        mWizard = true;
                        run = true;
                        ms = false;
                        break;
                    case (true, 31, 0):
                        Console.WriteLine("Он спит или просто умер?");
                        ms = false;
                        break;
                    case (true, 28, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w8 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 27, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w7 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 26, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w6 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 25, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w5 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 24, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w4 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 23, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w3 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 22, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w2 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 21, 0):
                        Console.WriteLine("Вы срезали пшеницу");
                        w1 = true;
                        ms = false;
                        Wheat++;
                        break;
                    case (true, 6, 0):
                        Console.WriteLine("Надпись на могиле:\nТ...е... не разобрать");
                        ms = false;
                        break;
                    case (true, 7, 0):
                        Console.WriteLine("Надпись на могиле:\nДрорганес");
                        ms = false;
                        break;
                    case (true, 8, 0):
                        Console.WriteLine("Надпись на могиле:\nТоинс");
                        ms = false;
                        break;
                    case (true, 9, 0):
                    case (true, 11, 0):
                    case (true, 12, 0):
                        Console.WriteLine("Надпись на могиле:\nНе разобрать");
                        ms = false;
                        break;
                    case (true, 10, 0):
                        Console.WriteLine("Надпись на могиле:\nЭбетт");
                        ms = false;
                        break;
                    case (true, 13, 0):
                        Console.WriteLine("Надпись на могиле:\nАртемий:Ъ");
                        ms = false;
                        break;
                    case (true, 4, 0):
                        Console.WriteLine("АААААА");
                        nms++;
                        break;
                    case (true, 4, 1):
                        Console.WriteLine("Я окружён.. Таков мой конец?\nЧто ж..");
                        nms++;
                        break;
                    case (true, 4, 2):
                        Console.WriteLine("ДАВАЙТЕ! Я готов принять свою судьбу..");
                        mlc = true;
                        nms = 0;
                        ms = false;
                        break;
                    case (true, 5, 0):
                        Console.WriteLine("*На другой стороне комнаты стоит скелет окутанный в лохмотья*");
                        nms++;
                        break;
                    case (true, 5, 1):
                        Console.WriteLine("..Лич?..");
                        nms++;
                        break;
                    case (true, 5, 2):
                        Console.WriteLine("Зови меня Транед, перед смертью знай.");
                        nms++;
                        break;
                    case (true, 5, 3):
                        Console.WriteLine("Я запомнил тебя.");
                        nms++;
                        break;
                    case (true, 5, 4):
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\t\t\t...\n\n\n\n");
                        nms = 0;
                        ms = false;
                        loc = 13;
                        yb = 2;
                        xb = 4;
                        y = 2;
                        x = 4;
                        run = true;
                        hp = 1;
                        break;
                    case (true, 14, 0):
                        Console.WriteLine("...");
                        nms++;
                        run = false;
                        mtrees = true;
                        break;
                    case (true, 14, 1):
                        Console.WriteLine("Тебе наверное интересно что это за дерево?");
                        nms++;
                        break;
                    case (true, 14, 2):
                        Console.WriteLine("..");
                        nms++;
                        break;
                    case (true, 14, 3):
                        Console.WriteLine("Говорят что из-за проклятия лича эта пещера \nхранит души тех кто погиб в ней.");
                        nms++;
                        break;
                    case (true, 14, 4):
                        Console.WriteLine("Я слышал что один волшебник посадил это дерево для того, \nчто-бы оно направляло души на поверхность.");
                        nms++;
                        break;
                    case (true, 14, 5):
                        Console.WriteLine("Хотел бы я, что бы это оказалось правдой..");
                        nms++;
                        break;
                    case (true, 14, 6):
                        Console.WriteLine("После моей смерти вряд ли кто-то будет ухаживать за этим местом.");
                        nms = 0;
                        ms = false;
                        mtrees_end = true;
                        run = true;
                        break;
                    case (true, 15, 0):
                        Console.WriteLine("О, проснулся?");
                        nms++;
                        run = false;
                        quest_thanks = true;
                        break;
                    case (true, 15, 1):
                        Console.WriteLine("Тебя принёс старик с кладбища, сказал что-ты лежал без сознания \nгде-то у входа в подземелье.");
                        nms++;
                        break;
                    case (true, 15, 2):
                        Console.WriteLine("Ты в таверне WindPeak! Безопасное место для тех кто хочет отдохнуть или выпить.");
                        nms++;
                        break;
                    case (true, 15, 3):
                        Console.WriteLine("Правда пить пока нечего..");
                        nms++;
                        break;
                    case (true, 15, 4):
                        Console.WriteLine("Но это вопрос времени!");
                        nms++;
                        break;
                    case (true, 15, 5):
                        Console.WriteLine("Кстати не переживай за комнату, старик заплатил за тебя.\nНеплохо было бы поблагодарить?");
                        nms++;
                        break;
                    case (true, 15, 6):
                        Console.WriteLine("Ладно, если что-то понадобиться обращайся.");
                        nms = 0;
                        ms = false;
                        run = true;
                        break;
                    case (true, 16, 0):
                        Console.WriteLine("Ты ведь тот парень которого я дотащил до таверны?");
                        nms++;
                        run = false;
                        quest_thanks_end = true;
                        break;
                    case (true, 16, 1):
                        Console.WriteLine("Обычно, потеряв сознание в гнезде монстров, авантюристы погибают.");
                        nms++;
                        break;
                    case (true, 16, 2):
                        Console.WriteLine("Но вокруг тебя не было ни души.");
                        nms++;
                        break;
                    case (true, 16, 3):
                        Console.WriteLine("Ты ведь видел его?");
                        nms++;
                        break;
                    case (true, 16, 4):
                        Console.WriteLine("..");
                        nms++;
                        break;
                    case (true, 16, 5):
                        Console.WriteLine("Постарайся не делать резких выводов.. \nТы можешь подумать что он запер нас тут.");
                        nms++;
                        break;
                    case (true, 16, 6):
                        Console.WriteLine("Но на деле это он заперт с нами.");
                        nms++;
                        break;
                    case (true, 16, 7):
                        Console.WriteLine("При следущей встрече скажи что мы были бы рад вновь его встретить.");
                        nms++;
                        break;
                    case (true, 16, 8):
                        Console.WriteLine("И передай эту сумку.");
                        nms = 0;
                        bag = true;
                        ms = false;
                        run = true;
                        quest_thanks_end = true;
                        break;
                    case (true, 17, 0):
                        Console.WriteLine("Выглядишь неважно.");
                        nms++;
                        run = false;
                        break;
                    case (true, 17, 1):
                        Console.WriteLine("Возле плантации есть источник, отпей из него, станет легче.");
                        nms++;
                        break;
                    case (true, 17, 2):
                        Console.WriteLine("Поговори с людьми вокруг, может узнаешь что-то новое.");
                        nms = 0;
                        ms = false;
                        run = true;
                        break;
                    case (true, 18, 0):
                        Console.WriteLine("Вы чувствуете прилив сил.");
                        nms = 0;
                        hp = maxhp;
                        ms = false;
                        break;
                    case (true, 19, 0):
                        Console.WriteLine("ZZZzzz");
                        nms++;
                        run = false;
                        break;
                    case (true, 19, 1):
                        Console.WriteLine("А!?");
                        nms++;
                        break;
                    case (true, 19, 2):
                        Console.WriteLine("Дрог я блъ тебя не вижу, я выпил вфё пиво в этом франом хфламешнике.");
                        nms++;
                        break;
                    case (true, 19, 3):
                        Console.WriteLine("*Хозяин таверны громко кашлянул*");
                        nms++;
                        break;
                    case (true, 19, 4):
                        Console.WriteLine("Ааагрх");
                        nms++;
                        break;
                    case (true, 19, 5):
                        Console.WriteLine("Чёрт, ты кто?");
                        nms++;
                        break;
                    case (true, 19, 6):
                        Console.WriteLine("АААААааа, ты тот парень которого старик приволок!?");
                        nms++;
                        break;
                    case (true, 19, 7):
                        Console.WriteLine("Ахереть ты как слепым котёнком в дыре той выжил?");
                        nms++;
                        break;
                    case (true, 19, 8):
                        Console.WriteLine("СТОЙ, не отвечай, это надо отметить.");
                        nms++;
                        break;
                    case (true, 19, 9):
                        Console.WriteLine("Ах да..");
                        nms++;
                        break;
                    case (true, 19, 10):
                        Console.WriteLine("Так орёл, давай так.");
                        nms++;
                        break;
                    case (true, 19, 11):
                        Console.WriteLine("Ты приносишь нам пиво, а я тебе то что в этой коробке.");
                        nms++;
                        break;
                    case (true, 19, 12):
                        Console.WriteLine("Бывай.!");
                        nms = 0;
                        ms = false;
                        run = true;
                        quest_beer = true;
                        break;
                    case (true, 20, 0):
                        Console.WriteLine("Если нужно пиво, сходи к источнику, собери пшеницу");
                        nms++;
                        run = false;
                        break;
                    case (true, 20, 1):
                        Console.WriteLine("Срежь её своим мечом.");
                        nms = 0;
                        ms = false;
                        run = true;
                        quest_beer_info = true;
                        break;
                    case (true, 29, 0):
                        Console.WriteLine("Отлично, скоро будет готово.");
                        Wheat = 0;
                        ms = false;
                        quest_beer_end = true;
                        break;
                    case (true, 30, 0):
                        Console.WriteLine("ZZZzzz");
                        run = false;
                        nms++;
                        break;
                    case (true, 30, 1):
                        Console.WriteLine("Готов уже?");
                        nms++;
                        break;
                    case (true, 30, 2):
                        Console.WriteLine("*Глубокий зевок*");
                        nms++;
                        break;
                    case (true, 30, 3):
                        Console.WriteLine("ИТАК");
                        nms++;
                        break;
                    case (true, 30, 4):
                        Console.WriteLine("GAMUL GLASS");
                        nms++;
                        break;
                    case (true, 30, 5):
                        Console.WriteLine("Я отдам тебе содержимое сундука, если перепьёшь меня!");
                        nms++;
                        break;
                    case (true, 30, 6):
                        Console.WriteLine("*Бармен смеясь* Ты и так пьян!");
                        nms++;
                        break;
                    case (true, 30, 7):
                        Console.WriteLine("GAMUT AI-MENU BURM");
                        nms++;
                        break;
                    case (true, 30, 8):
                        Console.Clear();
                        Console.WriteLine($"\t     Gamul Glass");
                        Console.WriteLine($"  Это знаменитая игра где опонентам раздают по три разных\n напитка, каждый из них должен выбрать какой он выпьет,\n а какие два отдаст опоненту.");
                        Console.WriteLine($"       ST - Стойкость игрока");
                        Console.WriteLine($"       DR - Уровень опьянения");
                        Console.WriteLine($"  Игрок проигрывает если уровень опьянения превышает стойкость.");
                        Console.ReadKey();
                        //Пивная дуэль
                        {
                            int stamina = 20;
                            int d_stamina = 20;
                            int drunk = 0;
                            int d_drunk = 0;
                            int b = 0;
                            int n = 0;
                            int menu = 1;
                            int d_menu = 1;
                            bool ready = false;
                            bool[] arr = new bool[6];
                            while (true)
                            {
                                if (ready)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n");
                                    n = 0;
                                    if (arr[0] == false)
                                    {
                                        n++;
                                        switch (ready, arr[0], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_drunk += 4;
                                                Console.WriteLine("\tДворф пьёт Пиво DR+4");
                                                break;
                                            case (true, false, false):
                                                drunk += 4;
                                                Console.WriteLine("\tДворф отдаёт Пиво DR+4");
                                                break;
                                        }
                                    }
                                    if (arr[1] == false)
                                    {
                                        n++;
                                        switch (ready, arr[1], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_drunk += 6;
                                                Console.WriteLine("\tДворф пьёт Дворфийский глинтвейн DR+6");
                                                break;
                                            case (true, false, false):
                                                drunk += 6;
                                                Console.WriteLine("\tДворф отдаёт Дворфийский глинтвейн DR+6");
                                                break;
                                        }
                                    }
                                    if (arr[2] == false)
                                    {
                                        n++;
                                        switch (ready, arr[2], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_drunk += 2;
                                                Console.WriteLine("\tДворф пьёт Медовуха DR+2");
                                                break;
                                            case (true, false, false):
                                                drunk += 2;
                                                Console.WriteLine("\tДворф отдаёт Медовуха DR+2");
                                                break;
                                        }
                                    }
                                    if (arr[3] == false)
                                    {
                                        n++;
                                        switch (ready, arr[3], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_stamina += 2;
                                                Console.WriteLine("\tДворф пьёт Ягодный фреш ST+2");
                                                break;
                                            case (true, false, false):
                                                stamina += 2;
                                                Console.WriteLine("\tДворф отдаёт Ягодный фреш ST+2");
                                                break;
                                        }
                                    }
                                    if (arr[4] == false)
                                    {
                                        n++;
                                        switch (ready, arr[4], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_stamina -= 6;
                                                Console.WriteLine("\tДворф пьёт Орочий грог ST-6");
                                                break;
                                            case (true, false, false):
                                                stamina -= 6;
                                                Console.WriteLine("\tДворф отдаёт Орочий грог ST-6");
                                                break;
                                        }
                                    }
                                    if (arr[5] == false)
                                    {
                                        n++;
                                        switch (ready, arr[5], d_menu == n)
                                        {
                                            case (true, false, true):
                                                d_drunk -= 4;
                                                Console.WriteLine("\tДворф отдаёт Грибной чай DR-4");
                                                break;
                                            case (true, false, false):
                                                drunk -= 4;
                                                Console.WriteLine("\tДворф отдаёт Грибной чай DR-4");
                                                break;
                                        }
                                    }
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                Console.WriteLine($"\t     Gamul Glass\n\tТы\t\t  Дворф");
                                Console.WriteLine($"       ST {stamina}\t\t ST   {d_stamina}");
                                Console.WriteLine($"       DR {drunk}\t\t DR   {d_drunk}");
                                if (b == 0)
                                {
                                    b = 0;
                                    while (b != 3)
                                    {
                                        b = 0;
                                        for (int i = 0; i < 6; i++)
                                        {
                                            arr[i] = false;
                                        }
                                        for (int i = 0; i < 6; i++)
                                        {
                                            if (random.Next(2) == 1)
                                            {
                                                arr[i] = true;
                                            }
                                        }
                                        for (int i = 0; i < 6; i++)
                                        {
                                            if (arr[i] == true) { b++; }
                                        }
                                    }
                                }
                                Console.Write("\nВыберете напиток который хотите выпить, \nостальные пойдут опоненту.\n");
                                n = 0;
                                if (arr[0])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Пиво DR+4");
                                    }
                                    else { Console.Write("\n\t  Пиво DR+4"); }
                                    switch (ready, arr[0], menu == n)
                                    {
                                        case (true, true, true):
                                            drunk += 4;
                                            break;
                                        case (true, true, false):
                                            d_drunk += 4;
                                            break;
                                    }
                                }
                                if (arr[1])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Дворфийский глинтвейн DR+6");
                                    }
                                    else { Console.Write("\n\t  Дворфийский глинтвейн DR+6"); }
                                    switch (ready, arr[1], menu == n)
                                    {
                                        case (true, true, true):
                                            drunk += 6;
                                            break;
                                        case (true, true, false):
                                            d_drunk += 6;
                                            break;
                                    }
                                }
                                if (arr[2])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Медовуха DR+2");
                                    }
                                    else { Console.Write("\n\t  Медовуха DR+2"); }
                                    switch (ready, arr[2], menu == n)
                                    {
                                        case (true, true, true):
                                            drunk += 2;
                                            break;
                                        case (true, true, false):
                                            d_drunk += 2;
                                            break;
                                    }
                                }
                                if (arr[3])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Ягодный фреш ST+2");
                                    }
                                    else { Console.Write("\n\t  Ягодный фреш ST+2"); }
                                    switch (ready, arr[3], menu == n)
                                    {
                                        case (true, true, true):
                                            stamina += 2;
                                            break;
                                        case (true, true, false):
                                            d_stamina += 2;
                                            break;
                                    }
                                }
                                if (arr[4])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Орочий грог ST-6");
                                    }
                                    else { Console.Write("\n\t  Орочий грог ST-6"); }
                                    switch (ready, arr[4], menu == n)
                                    {
                                        case (true, true, true):
                                            stamina -= 6;
                                            break;
                                        case (true, true, false):
                                            d_stamina -= 6;
                                            break;
                                    }
                                }
                                if (arr[5])
                                {
                                    n++;
                                    if (menu == n)
                                    {
                                        Console.Write("\n\t> Грибной чай DR-4");
                                    }
                                    else { Console.Write("\n\t  Грибной чай DR-4"); }
                                    switch (ready, arr[5], menu == n)
                                    {
                                        case (true, true, true):
                                            drunk -= 4;
                                            break;
                                        case (true, true, false):
                                            d_drunk -= 4;
                                            break;
                                    }
                                }
                                {
                                    if (d_drunk < 0)
                                    {
                                        d_drunk = 0;
                                    }
                                    if (drunk < 0)
                                    {
                                        drunk = 0;
                                    }
                                    if (d_drunk > 20)
                                    {
                                        d_drunk = 20;
                                    }
                                    if (drunk > 20)
                                    {
                                        drunk = 20;
                                    }
                                    if (d_stamina < 0)
                                    {
                                        d_stamina = 0;
                                    }
                                    if (stamina < 0)
                                    {
                                        stamina = 0;
                                    }
                                    if (d_stamina > 20)
                                    {
                                        d_stamina = 20;
                                    }
                                    if (stamina > 20)
                                    {
                                        stamina = 20;
                                    }
                                } //Выравнивание
                                if (drunk > stamina)
                                {
                                    d_win = true;
                                }
                                if (d_drunk > d_stamina)
                                {
                                    win = true;
                                }
                                if (win == true || d_win == true)
                                {
                                    break;
                                }
                                if (ready)
                                {
                                    ready = false;
                                    b = 0;
                                }
                                d_menu = 1 + random.Next(3);
                                if (ready == false && b != 0)
                                {
                                    ConsoleKeyInfo consoleKey = Console.ReadKey(true);
                                    switch (consoleKey.Key)
                                    {
                                        case ConsoleKey.F:
                                            ready = true;
                                            break;
                                        case ConsoleKey.W:
                                            menu--;
                                            break;
                                        case ConsoleKey.S:
                                            menu++;
                                            break;
                                        default:
                                            break;
                                    }
                                    if (menu == 0)
                                    {
                                        menu++;
                                    }
                                    if (menu == 4)
                                    {
                                        menu--;
                                    }
                                }
                            }
                            Console.Clear();
                            if (win && d_win == false)
                            {
                                Console.WriteLine("\n\n\n\n\t\t\tВы победили!");
                            }
                            if (win == false && d_win)
                            {
                                Console.WriteLine("\n\n\n\n\t\t\tВы проиграли..");
                            }
                            if (win && d_win)
                            {
                                Console.WriteLine("\n\n\n\n\t\t\tУ вас ничья!");
                            }
                            Console.WriteLine("\n\n\n");
                        }
                        nms++;
                        break;
                    case (true, 30, 9):
                        switch(win, d_win)
                        {
                            case (true, false):
                                Console.WriteLine("*Дворф сильно покачиваясь*\nААААААААА ХАРОШ");
                                break;
                            case (false, true):
                                Console.WriteLine("АААААААААХАХАХ \nMETUN MENU RUKHAS");
                                break;
                            case (true, true):
                                Console.WriteLine("ААААААААААХА");
                                break;
                        }
                        nms++;
                        break;
                    case (true, 30, 10):
                        switch (win, d_win)
                        {
                            case (true, false):
                                Console.WriteLine("Так и быть, держи!");
                                break;
                            case (false, true):
                                Console.WriteLine("Прости пацан, но сундук мой.");
                                break;
                            case (true, true):
                                Console.WriteLine("Пьёш как Дворф!");
                                break;
                        }
                        nms++;
                        break;
                    case (true, 30, 11):
                        switch (win, d_win)
                        {
                            case (true, false):
                                Console.WriteLine("*открывает сундук*");
                                break;
                            case (false, true):
                                Console.WriteLine("*Бармен проходя прошептал что-то на ухо дворфу*");
                                break;
                            case (true, true):
                                Console.WriteLine("У нас ничья, сундук твой!");
                                break;
                        }
                        nms++;
                        break;
                    case (true, 30, 12):
                        switch (win, d_win)
                        {
                            case (true, false):
                                Console.WriteLine("Этот амулет светится когда чувствует что-то спрятанное.");
                                amulet = true;
                                break;
                            case (false, true):
                                Console.WriteLine("Men gajamu, этот сундук тебе нужнее..");
                                break;
                            case (true, true):
                                Console.WriteLine("*открывает сундук*");
                                break;
                        }
                        nms++;
                        break;
                    case (true, 30, 13):
                        switch (win, d_win)
                        {
                            case (true, false):
                                Console.WriteLine("Спасибо за пиво! Gamut meliku!");
                                break;
                            case (false, true):
                                Console.WriteLine("Demup telek menu");
                                break;
                            case (true, true):
                                Console.WriteLine("Этот амулет светится когда чувствует что-то спрятанное.\nБереги себя и его!");
                                amulet = true;
                                break;
                        }
                        nms++;
                        break;
                    case (true, 30, 14):
                        Console.WriteLine("*Он опять ложится спать*");
                        if (amulet == false)
                        {
                            Console.WriteLine("*Вы открываете сундук, в нём лежит амулет. Интересно для чего он?*");
                            amulet = true;
                        }
                        nms = 0;
                        ms = false;
                        run = true;
                        break;
                    default:
                        break;
                }

                //Характеристики
                Console.WriteLine($"\nHP = {hp}/{maxhp}\nMP = {mp}/10\nPW = {pw}");
                Console.WriteLine("-----------");
                if (sw)
                {
                    Console.WriteLine("Меч +3");
                    pw = 5;
                }
                if (hat)
                {
                    Console.WriteLine("Шляпа");
                }
                if (bag)
                {
                    Console.WriteLine("Старая сумка");
                }
                if (amulet)
                {
                    Console.WriteLine("Амулет Дворфа");
                }
                if (potion > 0)
                {
                    Console.WriteLine($"Зелье {potion}");
                }
                if (ironHat)
                {
                    Console.WriteLine("Шлем + 10");
                }
                if (ironBib)
                {
                    Console.WriteLine("Кольцуга + 12");
                }
                if (ironBoots)
                {
                    Console.WriteLine("Сапоги + 8");
                }
                if (quest_beer_info == true && quest_beer_end == false)
                {
                    Console.WriteLine($"Пшеница {Wheat}/8");
                }
                if (sw || hat || bag || amulet)
                {
                    Console.WriteLine("-----------");
                }
                Console.WriteLine($"Золото - {money}м");

                //Временные данные
                Console.WriteLine("\n" + y);
                Console.WriteLine(x + "\n" + loc);

                //Управление
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.S:
                        if (run==true)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.W:
                        if (run==true)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (run==true)
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (run == true)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.F:
                        if (gm == true)
                        {
                            ms = true;
                        }
                        if (loc == 4d)
                        {
                            dc = true;
                        }
                        break;
                    default:
                        break;
                }

                //Движение врага
                if (runtime == 0 && hpe > 0 && (loc==3 || loc==15))
                {
                    if ((ye - y) == 1 || (ye - y) == -1 || (ye - y) == 0 || (xe - x) == 1 || (xe - x) == -1 || (xe - x) == 1)
                    {
                        if (ye > y)
                        {
                            ye--;
                        }
                        else if (ye < y)
                        {
                            ye++;
                        }
                        dir = true;
                        if (xe > x)
                        {
                            xe--;
                        }
                        else if (xe < x)
                        {
                            xe++;
                        }
                        dir = false;
                    } 
                    else {
                        if (ye > yb)
                        {
                            ye--;
                        }
                        else if (ye < yb)
                        {
                            ye++;
                        }
                        dir = true;
                        if (xe > xb)
                        {
                            xe--;
                        }
                        else if (xe < xb)
                        {
                            xe++;
                        }
                        dir = false;
                    }
                }
                if (runtime > 0)
                {
                    runtime--;
                }

                Console.Clear();
            }
        }
    }
}