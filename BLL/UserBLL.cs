using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public List<User> GetAll()
        {
            List<User> lstUser = null;

            using (var dbContext = new testEntities())
            {
                var user = dbContext.Users.ToList();
                lstUser = user.ToList();
            }

            return lstUser;
        }

        public bool Add(User objUser)
        {
            bool status = false;
            try
            {
                using (var dbContext = new testEntities())
                {
                    objUser.DateOfBirth = DateTime.Now;
                    objUser.Gender = "M";
                    objUser.IsActive = true;
                    dbContext.Users.Add(objUser);
                    if (dbContext.SaveChanges() > 0)
                        status = true;
                }
            }
            catch (Exception ex)
            {
            }

            return status;
        }

        public bool Update(User objUser)
        {
            return false;
        }
    }
}
