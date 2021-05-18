using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_exam_II.DTO;

namespace first_exam_II.Logic
{
    public class LogicFirstExamII
    {
        public Dto_CitizenComplaintNode junctionOfNodes(Dto_CitizenComplaintNode citizenComplaintNodeOne, Dto_CitizenComplaintNode citizenComplaintNodeTwo)
        {
            Dto_CitizenComplaintNode HeadOne = citizenComplaintNodeOne;
            Dto_CitizenComplaintNode HeadTwo = citizenComplaintNodeTwo;
            int countCountryListOne = 1;
            int countCountryListTwo = 1;
            int countCountryListTree = 1;

            Dto_CitizenComplaintNode countOne = citizenComplaintNodeOne;
            while (countOne.Next != null)
            {
                countCountryListOne++;
                countOne = countOne.Next;
            }

            Dto_CitizenComplaintNode countTwo = citizenComplaintNodeTwo;
            while (countTwo.Next != null)
            {
                countCountryListTwo++;
                countTwo = countTwo.Next;
            }

            int totalCountCountryList = countCountryListOne + countCountryListTwo;

            Dto_CitizenComplaintNode citizenComplaintNodeTree = new Dto_CitizenComplaintNode();
            for (int i = 0; i < totalCountCountryList; i++)
            {
                if (citizenComplaintNodeTree.citizenComplaint == null)
                {
                    citizenComplaintNodeTree.citizenComplaint = citizenComplaintNodeOne.citizenComplaint;
                    Dto_CitizenComplaintNode lastOne = citizenComplaintNodeOne;

                    for (int j = 0; j < countCountryListOne; j++)
                    {
                        DateTime dateTimeOne = lastOne.citizenComplaint.dateTime.Date;

                        if (dateTimeOne > citizenComplaintNodeTree.citizenComplaint.dateTime.Date)
                        {
                            citizenComplaintNodeTree.citizenComplaint = lastOne.citizenComplaint;
                        }

                        lastOne = lastOne.Next;
                    }

                    Dto_CitizenComplaintNode lastTwo = citizenComplaintNodeTwo;

                    for (int j = 0; j < countCountryListTwo; j++)
                    {
                        DateTime dateTimeTwo = lastTwo.citizenComplaint.dateTime.Date;

                        if (dateTimeTwo > citizenComplaintNodeTree.citizenComplaint.dateTime.Date)
                        {
                            citizenComplaintNodeTree.citizenComplaint = lastTwo.citizenComplaint;
                        }

                        lastTwo = lastTwo.Next;
                    }
                }
                else
                {
                    Dto_CitizenComplaintNode lastTree = citizenComplaintNodeTree;
                    while (lastTree.Next != null)
                    {
                        lastTree = lastTree.Next;
                    }

                    DateTime comparativeDate = citizenComplaintNodeOne.citizenComplaint.dateTime.Date;

                    Dto_CitizenComplaintNode comparativeLastOne = citizenComplaintNodeOne;

                    for (int j = 0; j < countCountryListOne; j++)
                    {
                        DateTime dateTimeOne = comparativeLastOne.citizenComplaint.dateTime.Date;

                        if (dateTimeOne <= comparativeDate)
                        {
                            comparativeDate = dateTimeOne;
                        }

                        comparativeLastOne = comparativeLastOne.Next;
                    }

                    Dto_CitizenComplaintNode comparativeLastTwo = citizenComplaintNodeTwo;

                    for (int j = 0; j < countCountryListTwo; j++)
                    {
                        DateTime dateTimeTwo = comparativeLastTwo.citizenComplaint.dateTime.Date;

                        if (dateTimeTwo <= comparativeDate)
                        {
                            comparativeDate = dateTimeTwo;
                        }

                        comparativeLastTwo = comparativeLastTwo.Next;
                    }

                    Dto_CitizenComplaintNode lastOne = citizenComplaintNodeOne;

                    for (int j = 0; j < countCountryListOne; j++)
                    {
                        DateTime dateTimeOne = lastOne.citizenComplaint.dateTime.Date;

                        if (dateTimeOne >= comparativeDate && dateTimeOne < lastTree.citizenComplaint.dateTime.Date)
                        {
                            comparativeDate = dateTimeOne;
                            Dto_CitizenComplaintNode tempCitizenComplaintNode = new Dto_CitizenComplaintNode();
                            tempCitizenComplaintNode.citizenComplaint = lastOne.citizenComplaint;
                            lastTree.Next = tempCitizenComplaintNode;
                        }

                        lastOne = lastOne.Next;
                    }

                    Dto_CitizenComplaintNode lastTwo = citizenComplaintNodeTwo;

                    for (int j = 0; j < countCountryListTwo; j++)
                    {
                        DateTime dateTimeTwo = lastTwo.citizenComplaint.dateTime.Date;

                        if (dateTimeTwo >= comparativeDate && dateTimeTwo < lastTree.citizenComplaint.dateTime.Date)
                        {
                            comparativeDate = dateTimeTwo;
                            Dto_CitizenComplaintNode tempCitizenComplaintNode = new Dto_CitizenComplaintNode();
                            tempCitizenComplaintNode.citizenComplaint = lastTwo.citizenComplaint;
                            lastTree.Next = tempCitizenComplaintNode;
                        }

                        lastTwo = lastTwo.Next;
                    }
                }
            }

            Dto_CitizenComplaintNode countTree = citizenComplaintNodeTree;
            while (countTree.Next != null)
            {
                countCountryListTree++;
                countTree = countTree.Next;
            }

            Console.WriteLine("------------ List One ------------");
            Console.WriteLine("\n");
            for (int j = 0; j < countCountryListOne; j++)
            {
                Console.WriteLine(citizenComplaintNodeOne.citizenComplaint.dateTime.Date);
                citizenComplaintNodeOne = citizenComplaintNodeOne.Next;
            }

            Console.WriteLine("");
            Console.WriteLine("------------ List Two ------------");
            Console.WriteLine("\n");
            for (int j = 0; j < countCountryListTwo; j++)
            {
                Console.WriteLine(citizenComplaintNodeTwo.citizenComplaint.dateTime.Date);
                citizenComplaintNodeTwo = citizenComplaintNodeTwo.Next;
            }

            Console.WriteLine("");
            Console.WriteLine("------------ List Tree ------------");
            Console.WriteLine("\n");
            for (int j = 0; j < countCountryListTree; j++)
            {
                Console.WriteLine(citizenComplaintNodeTree.citizenComplaint.dateTime.Date);
                citizenComplaintNodeTree = citizenComplaintNodeTree.Next;
            }

            return citizenComplaintNodeTree;
        }
    }
}
