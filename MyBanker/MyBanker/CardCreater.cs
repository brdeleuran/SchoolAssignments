using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class CardCreater
    {
        private string accountNumber = "3520";
        private string cardNumb = "";

        private string[] debetCardPrefix = new string[1] { "2400" };
        private string[] visaElectronPrefix = new string[6] { "4026", "417500", "4508", "4844", "4913", "4917" };
        private string[] visaPrefix = new string[1] { "4" };
        private string[] masterCardPrefix = new string[5] { "51", "52", "53", "54", "55" };
        private string[] maestroPrefix = new string[9] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
        private string[][] cards = new string[5][];
        public static List<string> accountList = new List<string>();
        private List<string> cardList = new List<string>();
        public static List<Card> accounts = new List<Card>();

        Random randomGen = new Random();
        
        private void cardArray()
        {
            cards[0] = debetCardPrefix;
            cards[1] = visaElectronPrefix;
            cards[2] = visaPrefix;
            cards[3] = masterCardPrefix;
            cards[4] = maestroPrefix;
        }

        public string AccountNumbGen()
        {
            try
            {
                while (true)
                {
                    int accountNumberLength = accountNumber.Length;
                    do
                    {
                        accountNumber += randomGen.Next(0, 10);

                    } while (accountNumber.Length <= 14);
                    for (int i = 0; i < accountList.Count; i++)
                    {
                        if (accountList[i] != accountNumber)
                        {
                            accountList.Add(accountNumber);
                            break;
                        }

                    }
                    return accountNumber;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string cardNumbGen(int choice)
        {
            try
            {
                if (choice <= 3)
                {
                    switch (choice)
                    {
                        case 0:
                            cardNumb += cards[0][randomGen.Next(0, debetCardPrefix.Length)];
                            do
                            {
                                int i = cardNumb.Length;
                                cardNumb += randomGen.Next(0, 10);
                                if (i == 4 || i == 8 || i == 12)
                                {
                                    cardNumb += " ";
                                }

                            } while (cardNumb.Length <= 16);
                            for (int i = 0; i < cardList.Count; i++)
                            {
                                if (cardList[i] != cardNumb)
                                {
                                    cardList.Add(cardNumb);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            cardNumb += cards[1][randomGen.Next(0, visaElectronPrefix.Length)];
                            do
                            {
                                int i = cardNumb.Length;
                                cardNumb += randomGen.Next(0, 10);
                                if (i == 4 || i == 8 || i == 12)
                                {
                                    cardNumb += " ";
                                }

                            } while (cardNumb.Length <= 16);
                            for (int i = 0; i < cardList.Count; i++)
                            {
                                if (cardList[i] != cardNumb)
                                {
                                    cardList.Add(cardNumb);
                                    break;
                                }
                            }
                            break;

                        case 2:
                            cardNumb += cards[2][randomGen.Next(0, visaPrefix.Length)];
                            do
                            {
                                int i = cardNumb.Length;
                                cardNumb += randomGen.Next(0, 10);
                                if (i == 4 || i == 8 || i == 12)
                                {
                                    cardNumb += " ";
                                }

                            } while (cardNumb.Length <= 16);
                            for (int i = 0; i < cardList.Count; i++)
                            {
                                if (cardList[i] != cardNumb)
                                {
                                    cardList.Add(cardNumb);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            cardNumb += cards[3][randomGen.Next(0, masterCardPrefix.Length)];
                            do
                            {
                                int i = cardNumb.Length;
                                cardNumb += randomGen.Next(0, 10);
                                if (i == 4 || i == 8 || i == 12)
                                {
                                    cardNumb += " ";
                                }

                            } while (cardNumb.Length <= 16);
                            for (int i = 0; i < cardList.Count; i++)
                            {
                                if (cardList[i] != cardNumb)
                                {
                                    cardList.Add(cardNumb);
                                    break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    cardNumb += cards[4][randomGen.Next(0, maestroPrefix.Length)];
                    do
                    {
                        int i = cardNumb.Length;
                        cardNumb += randomGen.Next(0, 10);
                        if (i == 4 || i == 8 || i == 12 || i == 16)
                        {
                            cardNumb += " ";
                        }
                            
                    } while (cardNumb.Length <= 19);
                    for (int i = 0; i < cardList.Count; i++)
                    {
                        if (cardList[i] != cardNumb)
                        {
                            cardList.Add(cardNumb);
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return cardNumb;
        }

        public CardCreater(string name, int cardChoice)
        {
            cardArray();
            string accountNumb = AccountNumbGen();
            string cardNumb = cardNumbGen(cardChoice);
            int masterVisaExpiryDate = 0624;
            int maestroExpiryDate = 0225;

            switch (cardChoice)
            {
                case 0:
                    accounts.Add(new DebetCard(name, cardNumb, accountNumb));
                    break;
                case 1:
                    accounts.Add(new VisaElectron(name, cardNumb, accountNumb, masterVisaExpiryDate));
                    break;
                case 2:
                    accounts.Add(new Visa(name, cardNumb, accountNumb, masterVisaExpiryDate));
                    break;
                case 3:
                    accounts.Add(new Mastercard(name, accountNumb, cardNumb, masterVisaExpiryDate));
                    break;
                case 4:
                    accounts.Add(new Maestro(name, accountNumb, cardNumb, maestroExpiryDate));
                    break;
                default:
                    break;
            }
        }
    }
}
