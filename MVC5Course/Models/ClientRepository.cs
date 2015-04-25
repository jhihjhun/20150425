using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(x => x.IsDelete == false);
        }

        public Client Find(int id)
        {
            return this.All().FirstOrDefault(x => x.ClientId == id);
        }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}