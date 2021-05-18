using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_exam_II.DTO;

namespace first_exam_II.DAO
{
    public class Dao_CitizenComplaint
    {
        public Dto_CitizenComplaintNode createCitizenComplaint(List<int> Code, List<string> PersonName, List<int> Document, List<string> Date, List<string> Reason)
        {
            List<Dto_CitizenComplaint> citizenComplaint = new List<Dto_CitizenComplaint>();

            for (int i = 0; i < PersonName.Count; i++)
            {
                citizenComplaint.Add(new Dto_CitizenComplaint()
                {
                    code = Code[i],
                    personName = PersonName[i],
                    document = Document[i],
                    dateTime = DateTime.Parse(Date[i]),
                    reason = Reason[i],
                });
            }

            Dao_CitizenComplaintNode dao_CitizenComplaintNode = new Dao_CitizenComplaintNode();
            Dto_CitizenComplaintNode citizenComplaintNode = dao_CitizenComplaintNode.createCitizenComplaintNode(citizenComplaint);
            return citizenComplaintNode;
        }
    }
}
