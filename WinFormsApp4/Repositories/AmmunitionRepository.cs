using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;

namespace WinFormsApp4.Repositories
{
    public sealed class AmmunitionRepository
    {
        private readonly List<Ammunition> _ammunitions = new();

        public void Add(Ammunition ammunition)
        {
            if (_ammunitions.Any(a => a.Id == ammunition.Id))
            {
                throw new InvalidOperationException("Ammunition with the same ID already exists.");
            }

            _ammunitions.Add(ammunition);
        }

        public void Update(
            Guid ammunitionId,
            Ammunition ammunition)
        {
            var index = _ammunitions.FindIndex(a => a.Id == ammunitionId);

            if (index == -1)
            {
                throw new KeyNotFoundException("Ammunition not found.");
            }

            _ammunitions[index] = ammunition;
        }

        public void Delete(
            Guid ammunitionId)
        {
            var index = _ammunitions.FindIndex(a => a.Id == ammunitionId);

            if (index == -1)
            {
                throw new KeyNotFoundException("Ammunition not found.");
            }

            _ammunitions.RemoveAt(index);
        }

        public void Clear()
        {
            _ammunitions.Clear();
        }

        public List<Ammunition> GetAll()
        {
            return _ammunitions;
        }

        public Ammunition GetById(Guid id)
        {
            return _ammunitions.FirstOrDefault(a => a.Id == id);
        }

        public List<Ammunition> SearchByName(string name)
        {
            return _ammunitions
                .Where(a => a.Name.Value.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Ammunition> SearchByPurpose(AmmunitionPurpose purpose)
        {
            return _ammunitions
                .Where(a => a.Purpose == purpose)
                .ToList();
        }

        public List<Ammunition> SearchByOriginCountry(string originCountry)
        {
            return _ammunitions
                .Where(a => a.OriginCountry.Name.Contains(originCountry, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
