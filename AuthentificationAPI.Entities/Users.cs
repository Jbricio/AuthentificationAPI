using Campus.Core;

namespace AuthentificationAPI.Entities
{
    public class Users: IEntityBase<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
