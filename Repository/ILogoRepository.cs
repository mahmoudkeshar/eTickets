using eTickets.Migrations;

namespace eTickets.Repository
{
	public interface ILogoRepository
	{
		
		public void Add(Logo logo);
		public void UpdateLogo(Logo logo);
		public void Delete(int ID);
		
		public Logo GetById();
		public void Save();
	}
}
