using System;

class InteractiveNovel
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Вы находитесь на развилке в таинственном лесу. Что вы хотите сделать?");
            Console.WriteLine("1. Пойти дальше в лес.");
            Console.WriteLine("2. Вернуться назад к дороге.");
            Console.WriteLine("3. Разжечь огонь на привале.");
            Console.WriteLine("4. Исследовать ближайшие кусты.");
            Console.WriteLine("5. Выйти из игры.");

            string choice1 = Console.ReadLine();
            if (choice1 == "5")
                break;

            switch (choice1)
            {
                case "1":
                    StepIntoTheForest();
                    break;
                case "2":
                    BackToTheRoad();
                    break;
                case "3":
                    CampFire();
                    break;
                case "4":
                    ExploreBushes();
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
        }
    }

    static void StepIntoTheForest()
    {
        Console.WriteLine("Вы углубляетесь в лес и слышите шорох. Что делать?");
        Console.WriteLine("1. Проверить шорох.");
        Console.WriteLine("2. Убежать.");
        Console.WriteLine("3. Сложить оружие и ждать.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы находите кролика! Он подбегает к вам и уходит. Вы расслабляетесь.");
            GoodEnding("Вы нашли мир и спокойствие в лесу!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы убегаете и теряете дорогу. Вам становится страшно. Вы остаетесь в лесу навсегда.");
            BadEnding("Вы не смогли найти дорогу и заблудились навсегда.");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Вы остаетесь на месте и успокаиваетесь. Проходит час, и шорох исчезает.");
            ContinueFurther();
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void ContinueFurther()
    {
        Console.WriteLine("Вы решаете продолжить. Вдруг вы видите две тропинки: одна ведет к свету, другая — в темноту.");
        Console.WriteLine("1. Пойти к свету.");
        Console.WriteLine("2. Пойти в темноту.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы выходите к красивому ручью и находите отдыхающего купца. Он одаривает вас золотом!");
            GoodEnding("Вы нашли богатство и счастье!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы оказались в темной пещере. Вдруг к вам подходит дикий зверь.");
            BadEnding("Зверь нападает на вас.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void BackToTheRoad()
    {
        Console.WriteLine("Вы вернулись к дороге. Что вы хотите сделать?");
        Console.WriteLine("1. Подождать помощи.");
        Console.WriteLine("2. Идти по дороге дальше.");
        Console.WriteLine("3. Сходить к заброшенному дому.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы ждали три часа, и вас нашли. Вы в безопасности!");
            GoodEnding("Вы дождались спасения!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы идете долго и находите зловещий замок. Вам становится страшно.");
            BadEnding("Замок охраняет мрачный дух.");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Внутри дома вы находите клад с древними артефактами.");
            GoodEnding("Вы стали обладателем древних сокровищ!");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void CampFire()
    {
        Console.WriteLine("Вы разожгли огонь и начали готовить еду. Вдруг вы замечаете тень.");
        Console.WriteLine("1. Подойти к тени.");
        Console.WriteLine("2. Убежать от огня.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Тень оказывается вашим другом! Вы вместе выживете и расскажете истории.");
            GoodEnding("Вы нашли друга в лесу!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы упали в яму. К сожалению, вам не выбраться.");
            BadEnding("Вы не смогли выбраться из ямы.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void ExploreBushes()
    {
        Console.WriteLine("Вы решили исследовать кусты и находите странный амулет.");
        Console.WriteLine("1. Взять амулет и продолжить путь.");
        Console.WriteLine("2. Оставить амулет и вернуться назад.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Амулет дает вам силу и защиту. Вы легко находите выход из леса!");
            GoodEnding("Вы стали могущественным благодаря амулету!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы теряете возможность защититься от зверей леса и пропадаете.");
            BadEnding("Вы не смогли вернуться.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 6: Найти пещеру
    static void FindCave()
    {
        Console.WriteLine("Вы находите вход в пещеру.");
        Console.WriteLine("1. Войти в пещеру.");
        Console.WriteLine("2. Игнорировать и идти дальше.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Внутри пещеры вы находите древние руины и сокровища.");
            GoodEnding("Вы стали героем, открывшим ужасные секреты!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы оставляете пещеру и продолжаете свой путь, но ничем не богаты.");
            BadEnding("Возможно, вы пропустили что-то важное.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 7: Переправиться через реку
    static void CrossRiver()
    {
        Console.WriteLine("Вы наткнулись на широкую реку.");
        Console.WriteLine("1. Попробовать переправиться через реку.");
        Console.WriteLine("2. Найти место для перехода вброд.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы тонете! К сожалению, это конец.");
            BadEnding("Вы не смогли переправиться через реку.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы нашли безопасное место для перехода и успешно переправились.");
            GoodEnding("Вы преодолели реку без потерь.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 8: Встретить странника
    static void MeetWanderer()
    {
        Console.WriteLine("Вы встречаете странствующего мудреца.");
        Console.WriteLine("1. Попросить его о советах.");
        Console.WriteLine("2. Игнорировать его.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Мудрец дает вам важный совет, который помогает вам выжить.");
            GoodEnding("Вы спасены благодаря мудрости старца!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы проходите мимо и теряете важную возможность.");
            BadEnding("Вы не воспользовались советом.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 9: Найти еду
    static void FindFood()
    {
        Console.WriteLine("Вы ищете еду.");
        Console.WriteLine("1. Собрать ягоды.");
        Console.WriteLine("2. Поймать рыбу.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Ягоды оказались ядовитыми! Вам становится плохо.");
            BadEnding("Вы отравились ядовитыми ягодами.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы поймали рыбу и утолили голод.");
            GoodEnding("Вы собрали еду и остались в живых!");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 10: Помочь животному
    static void HelpAnimal()
    {
        Console.WriteLine("Вы видите раненое животное.");
        Console.WriteLine("1. Помочь ему.");
        Console.WriteLine("2. Идти дальше.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Животное благодарит вас и помогает вам найти дорогу.");
            GoodEnding("Вы стали другом леса и нашли выход.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы оставляете животное и теряете возможность.");
            BadEnding("Вы могли помочь, но проигнорировали.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 11: Пройти мимо хижины
    static void PassByHut()
    {
        Console.WriteLine("Вы видите хижину в лесу.");
        Console.WriteLine("1. Зайти в хижину.");
        Console.WriteLine("2. Пройти мимо.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Внутри хижины вы находите старую ведьму. Она предлагает вам соглашение.");
            GoodEnding("Вы выиграли обретение магических сил, но оказались под контролем ведьмы!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы проходите мимо и не поддаются искушению.");
            BadEnding("Вы никогда не узнаете, что могло бы произойти.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 12: Найти карту
    static void FindMap()
    {
        Console.WriteLine("Вы находите старую карту, указывающую на места сокровищ.");
        Console.WriteLine("1. Попробовать использовать карту.");
        Console.WriteLine("2. Оставить карту и продолжить путь.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Карта приводит вас к сокровищам, и вы становитесь богатым!");
            GoodEnding("Вы нашли сокровища и стали миллионером!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы пропускаете возможность узнать о сокровищах.");
            BadEnding("Непонятно, как бы сложились ваши приключения.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 13: Увидеть призрак
    static void SeeGhost()
    {
        Console.WriteLine("Вы видите призрак, который указывает на что-то.");
        Console.WriteLine("1. Пойти за призраком.");
        Console.WriteLine("2. Убежать от страха.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Призрак приводит вас к утерянному кладбищу и показывает вам тайну.");
            GoodEnding("Вы раскрыли древнюю тайну и стали хранителем истории.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы убегаете и теряете возможность узнать важное.");
            BadEnding("Страх взял верх, и вы упустили шанс.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 14: Встретить бандитов
    static void MeetBandits()
    {
        Console.WriteLine("Вы сталкиваетесь с бандой разбойников.");
        Console.WriteLine("1. Попробовать договориться.");
        Console.WriteLine("2. Вступить в бой.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Бандиты решают отпустить вас за вашу смелость.");
            GoodEnding("Вы успешно избежали конфликта.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("К сожалению, вас одолели и забрали все ваши вещи.");
            BadEnding("Вы потеряли все.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 15: Найти волшебное дерево
    static void FindMagicTree()
    {
        Console.WriteLine("Вы находите волшебное дерево, которое предлагает вам желание.");
        Console.WriteLine("1. Попросить о богатстве.");
        Console.WriteLine("2. Попросить о силе.");
        Console.WriteLine("3. Попросить о мире.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Дерево исполняет ваше желание, но богатство приносит проблемы.");
            BadEnding("Вы потеряли друзей ради денег.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Сила делает вас могущественным, но изолирует от людей.");
            BadEnding("Вы остались одиноки с силой.");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Дерево исполняет ваше желание, и мир вокруг вас становится лучше.");
            GoodEnding("Вы принесли мир и счастье окружающим!");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 16: Исследовать мост
    static void ExploreBridge()
    {
        Console.WriteLine("Вы находите старый, шаткий мост.");
        Console.WriteLine("1. Перейти через мост.");
        Console.WriteLine("2. Вернуться назад.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Мост ломается, но вы успеваете перебраться!");
            GoodEnding("Вы успешно пересекли опасный мост.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы возвращаетесь назад и остаетесь в безопасности.");
            BadEnding("Вы пропустили возможность узнать, что было на другой стороне.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 17: Встретить демонов
    static void EncounterDemons()
    {
        Console.WriteLine("Вы сталкиваетесь с демонами, охраняющими вход в мир.");
        Console.WriteLine("1. Сразиться с демонами.");
        Console.WriteLine("2. Попытаться договориться с ними.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Демоны подавляют вас.");
            BadEnding("Вы не смогли победить демонов.");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы успешно убедили их отпустить вас.");
            GoodEnding("Вы нашли способ избежать конфликта.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 18: Найти карту сокровищ
    static void FindTreasureMap()
    {
        Console.WriteLine("Вы находите старую карту с указанием местоположения сокровищ.");
        Console.WriteLine("1. Пойти искать сокровища.");
        Console.WriteLine("2. Оставить карту.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы нашли сокровища и стали богатым!");
            GoodEnding("Вы благодаря карте стали миллионером!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы не узнали о множестве возможностей.");
            BadEnding("Вы проигнорировали шанс на удачу.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 19: Встретить старца
    static void MeetOldMan()
    {
        Console.WriteLine("Вы встретили старца, который просит о помощи.");
        Console.WriteLine("1. Помогите ему.");
        Console.WriteLine("2. Игнорировать его.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Старец благодарит вас и дает вам мудрые советы.");
            GoodEnding("Вы стали мудрее благодаря благородным поступкам!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Старец уходит, так и не получив помощи.");
            BadEnding("Вы могли бы помочь, но проигнорировали.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    // Шаг 20: Ощущение дуновения ветра
    static void SenseBreeze()
    {
        Console.WriteLine("Вы ощущаете прохладный ветер, который указывает вам путь.");
        Console.WriteLine("1. Следуйте за ветром.");
        Console.WriteLine("2. Остановиться и остаться на месте.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Ветер приводит вас к безопасному месту.");
            GoodEnding("Вы нашли себе укрытие благодаря ветру!");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы остались в том месте, где столкнулись с проблемами.");
            BadEnding("Вы потеряли время и возможности.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }
    }

    static void GoodEnding(string reason)
    {
        Console.WriteLine($"Конец истории: {reason}");
        EndingSummary();
    }

    static void BadEnding(string reason)
    {
        Console.WriteLine($"Конец истории: К сожалению, ваши решения привели к печальным последствиям. {reason}");
        EndingSummary();
    }

    static void EndingSummary()
    {
        Console.WriteLine("Игра окончена. Хотите попробовать снова? (да/нет)");
        string replayChoice = Console.ReadLine();

        if (replayChoice.ToLower() == "да")
        {
            Main(new string[] { });
        }
        else
        {
            Console.WriteLine("Спасибо за игру! До встречи!");
        }
    }
}
