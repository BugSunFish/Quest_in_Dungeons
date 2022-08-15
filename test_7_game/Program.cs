using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_7_game
{
    internal class Program 
    {
        
        static void Main(string[] args)
        {
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
            int mp = 10;
            int pw = 2;
            int money = 12;
            bool hat = false;
            //Спавн игрока
            //int y = 5, x = 7;
            int y = 5, x = 7;
            //Буфер
            int yb = y, xb = x;
            int ybe = ye, xbe = xe;
            //Номер локации
            int loc = 11;
            //Состояние диалога
            bool ms = false;
            //Готовность к диалогу
            bool gm = false;
            //Меч
            bool sw = false;
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
            //Квест от Бармена
            bool quest_thanks = false;
            bool quest_thanks_end = false;
            //Квест от Дворфа
            bool quest_beer = false;
            bool quest_beer_end = false;

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
                if (y==ye && x==xe && runtime==0 && loc==3) 
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
                                if (hat == true)
                                {
                                    Console.Write("Шляпа\t");
                                }
                                break;
                            case (2, 2):
                                Console.Write("   Назад\t");
                                if (hat == true)
                                {
                                    Console.Write("<Шляпа>\t");
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
                                case 3:
                                    Enemy(i, j);
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
                        }
                        
                    }
                    Console.WriteLine("");
                }

                //Зона действия
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
                        if (mtrees == false)
                        {
                            Console.WriteLine("Старик с лопатой\nПогворить: F");
                            locms = 14;
                            gm = true;
                            mtrees = true;
                            run = false;
                        }
                        if (quest_thanks == true && quest_thanks_end == false)
                        {
                            Console.WriteLine("Старик с лопатой\nПогворить: F");
                            locms = 16;
                            gm = true;
                            quest_thanks_end = true;
                            run = false;
                        }
                        break;
                    case ( 3, 8, false, 11):
                        if (quest_thanks == false)
                        {
                            Console.WriteLine("Хозяин таверны\nПогворить: F");
                            locms = 15;
                            gm = true;
                            run = false;
                            quest_thanks = true;
                        }
                        break;
                }
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
                        run = true;
                        break;
                    case (true, 15, 0):
                        Console.WriteLine("О, проснулся?");
                        nms++;
                        break;
                    case (true, 15, 1):
                        Console.WriteLine("Тебя принёс старик с кладбища, сказал что-ты лежал без созния \nгде-то у входа в подземелье.");
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
                        break;
                    case (true, 16, 1):
                        Console.WriteLine("");
                        nms++;
                        break;
                    default:
                        break;
                }

                //Характеристики
                Console.WriteLine($"\nHP = {hp}/20\nMP = {mp}/10\nPW = {pw}");
                Console.WriteLine("-----------");
                if (sw == true)
                {
                    Console.WriteLine("Меч +3");
                    pw = 5;
                }
                if (hat == true)
                {
                    Console.WriteLine("Шляпа");
                }
                if (sw == true)
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
                if (runtime == 0 && hpe > 0 && loc==3)
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