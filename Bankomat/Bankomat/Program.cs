namespace Kopfkino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int password = 8978, checkPass, attempts = 3, balans = 1500000, menuChoice, transactionSum, phoneNumber, newPass;

            Console.WriteLine("Assalamu Aleykum, Kopfkino bankiga xush kelibsiz!!!");
        metka:
            Console.Write("Kartangizning kodini kiriting: ");
            checkPass = int.Parse(Console.ReadLine());

            if (checkPass == password && attempts >= 1)
            {
            backToMenu:
                Console.Write("Bajarmoqchi bo`lgan amalingizni tanlang:\n1 - Balansni tekshirish\n2 - Naqd pul yechish\n3 - Balansni to`ldirish\n4 - SMS habar hizmatini ulash\n5 - Parol o`zgartirish\n0 - Bekor qilish\nRaqam kiriting:");
                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.Write($"Kartangizning hisobida {balans} sum pul qolgan.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting: ");
                        menuChoice = int.Parse(Console.ReadLine());
                        if (menuChoice == 1)
                        {
                            goto backToMenu;
                        }
                        else
                        {
                            Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");

                        }
                        break;
                    case 2:
                    balansCheck:
                        Console.Write($"Hozir balansingizda {balans} sum bor.\nYechoqchi bo`lgan summangini tanlang(Kompaniyamizning hizmat narxi 1%):\n1 - 50 000\n2 - 100 000\n3 - 200 000\n4 - 300 000\n5 - 500 000\n6 - Boshqa summani kiritish\n0 - Orqaga\nRaqam kiriting:");
                        menuChoice = int.Parse(Console.ReadLine());
                        switch (menuChoice)
                        {
                            case 1:
                                if (balans >= 50000 + (50000 / 100))
                                {
                                    Console.Write($"Kartangizdan 50 500 sum yechildi, balansingizda {balans - (50000 + (50000 / 100))} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());
                                    balans = balans - 50000 + (50000 / 100);
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 2:
                                if (balans >= 100000 + (100000 / 100))
                                {
                                    Console.Write($"Kartangizdan 101 000 sum yechildi, balansingizda {balans - (100000 + (100000 / 100))} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());
                                    balans = balans - 100000 + (100000 / 100);
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 3:
                                if (balans >= 200000 + (200000 / 100))
                                {
                                    Console.Write($"Kartangizdan 202 000 sum yechildi, balansingizda {balans - (200000 + (200000 / 100))} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());
                                    balans = balans - 200000 + (200000 / 100);
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 4:
                                if (balans >= 300000 + (300000 / 100))
                                {
                                    Console.Write($"Kartangizdan 300 000 sum yechildi, balansingizda {balans - (300000)} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());
                                    balans = balans - 300000 + (300000 / 100);
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 5:
                                if (balans >= 500000 + (500000 / 100))
                                {
                                    Console.Write($"Kartangizdan 505 000 sum yechildi, balansingizda {balans - (500000 + (500000 / 100))} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());
                                    balans = balans - 500000 + (500000 / 100);
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 6:
                                Console.Write("Yechmoqchi bo`lgan summangizni kiriting: ");
                                transactionSum = int.Parse(Console.ReadLine());
                                if (balans >= transactionSum + (transactionSum / 100))
                                {
                                    Console.Write($"Kartangizdan {transactionSum + (transactionSum / 100)} sum yechildi, balansingizda {balans - (transactionSum + (transactionSum / 100))} sum pul qoldi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:  ");
                                    menuChoice = int.Parse(Console.ReadLine());

                                    balans = balans - (transactionSum + (transactionSum / 100));
                                    if (menuChoice == 1)
                                    {
                                        goto backToMenu;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Siz kiritgan summani yechish uchun balansingizda mablag` yetarli emas, boshqa summa kiritib ko`ring");
                                    goto balansCheck;
                                }
                                break;
                            case 0:
                                goto backToMenu;
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Write("SMS habar hizmatini ulamoqchi bo`lgan raqamingizni kiriting(Misol: 90 1234567): ");
                        phoneNumber = int.Parse(Console.ReadLine());
                        Console.Write($"Hizmat {phoneNumber} raqamiga muviffaqiyatli ulandi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting: ");
                        menuChoice = int.Parse(Console.ReadLine());
                        if (menuChoice == 1)
                        {
                            goto backToMenu;
                        }
                        else
                        {
                            Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                        }
                        break;
                    case 5:
                    checkPassword:
                        Console.Write("Eski parolingizni kiriting:");
                        checkPass = int.Parse(Console.ReadLine());
                        if (checkPass == password)
                        {
                        checkPass:
                            Console.Write("Yangi parolni kiriting: ");
                            newPass = int.Parse(Console.ReadLine());
                            checkPass = newPass;
                            Console.Write("Yangi parolni tasdiqlang: ");
                            newPass = int.Parse(Console.ReadLine());
                            if (checkPass == newPass)
                            {
                                password = newPass;
                                Console.Write("Parolingiz muvaffaqiyatli almashtirildi.\nYana qandaydir amal qilmoqchimisiz?\n1-Ha\n0-Yoq\nSon kiriting:");
                                menuChoice = int.Parse(Console.ReadLine());
                                if (menuChoice == 1)
                                {
                                    goto backToMenu;
                                }
                                else
                                {
                                    Console.WriteLine("Kompaniyamiz hizmatlaridan foydalanganingiz uchun raxmat)");
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Parol tasdiqlashda xatoga yo`l qo`ydingiz!");
                                goto checkPass;
                            }
                        }
                        else
                        {
                            attempts--;
                            if (attempts < 1)
                            {
                                Console.Write($"Kod hato terilganligi sababli kartangiz bloklandi, blokdan chiqarish uchun bankka murojat qiling.\nKuningiz xayrli o`tsin)");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Siz kiritgan parol hato,sizda qolgan urunishlar soni {attempts} ta, qayta urunib ko`ring! ");
                                goto checkPassword;
                            }
                        }

                    default:

                        break;
                }
            }
            else
            {
                attempts--;
                if (attempts < 1)
                {
                    Console.Write($"Kod hato terilganligi sababli kartangiz bloklandi, blokdan chiqarish uchun bankka murojat qiling.\nKuningiz xayrli o`tsin)");
                    return;
                }
                else
                {
                    Console.WriteLine($"Siz kiritgan parol hato,sizda qolgan urunishlar soni {attempts} ta, qayta urunib ko`ring! ");

                }
            }

        }
    }
}