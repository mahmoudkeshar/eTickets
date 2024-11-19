namespace eTickets.Repository
{
	public class LogoRepository : ILogoRepository
	{
		private readonly AppDbContext appDbContext;

		public LogoRepository(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
		}
		public void Add(Logo logo)
		{
			appDbContext.Add(logo);

		}
		public Logo GetById( )
		{
			Logo logo = appDbContext.logos.FirstOrDefault();
			return logo;
		}

		public void Delete(int ID)
		{
			Logo logo = GetById();
			appDbContext.logos.Remove(logo);


		}




		public void UpdateLogo(Logo logo)
		{
			appDbContext.Update(logo);
		}

		public void Save()
		{
			appDbContext.SaveChanges();
		}


	}
}
