using System.Data.Entity;

namespace Kcsara.Training.Models
{
    public class KCSARAAuthModelInitializer : DropCreateDatabaseIfModelChanges<AuthDatabaseEntities>
    {
        protected override void Seed(AuthDatabaseEntities context)
        {
            base.Seed(context);
            /// TODO: Seed the database with some data.
        }
    }
}