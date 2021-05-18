using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_exam_II.DTO;

namespace first_exam_II.DAO
{
    public class Dao_CitizenComplaintNode
    {
        public Dto_CitizenComplaintNode citizenComplaintNode;
        public Dto_CitizenComplaintNode Head;

        public Dto_CitizenComplaintNode createCitizenComplaintNode(List<Dto_CitizenComplaint> citizenComplaints)
        {
            for (int i = 0; i < citizenComplaints.Count; i++)
            {
                citizenComplaintNode = AddCitizenComplaint(citizenComplaints[i]);
            }

            return citizenComplaintNode;
        }

        public Dto_CitizenComplaintNode AddCitizenComplaint(Dto_CitizenComplaint citizenComplaint)
        {
            Dto_CitizenComplaintNode citizenComplaintNode = new Dto_CitizenComplaintNode();
            citizenComplaintNode.citizenComplaint = citizenComplaint;

            if (Head == null)
            {
                Head = citizenComplaintNode;
            }
            else
            {
                Dto_CitizenComplaintNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = citizenComplaintNode;
            }

            return Head;
        }
    }
}
