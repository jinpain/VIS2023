using DeceasedPatientsRegistry.Domain.Entities;

namespace DeceasedPatientsRegistry.Data.Filters
{
    public class HeadersFilterTable
    {
        public Dictionary<string, List<(string, bool)>> FilterOptions = new();
        public HeadersFilterTable() => SetBaseOptions();
        public List<Patient> Filter(List<Patient> obj)
        {
            List<Patient> filtered = new();
            foreach (Patient item in obj)
            {
                if (!FilterOptions["Вскрытие"].FirstOrDefault(x => x.Item1 == item.AutopsyType.ToString()).Item2)
                    continue;

                if (!FilterOptions["ОНКО"].FirstOrDefault(x => x.Item1 == (item.Oncology ? "Да" : "Нет")).Item2)
                    continue;

                if (!FilterOptions["Фамилия"].FirstOrDefault(x => x.Item1 == item.Lastname).Item2)
                    continue;

                if (!FilterOptions["Имя"].FirstOrDefault(x => x.Item1 == item.Firstname).Item2)
                    continue;

                if (!FilterOptions["Отчество"].FirstOrDefault(x => x.Item1 == item.Surname).Item2)
                    continue;

                if (!FilterOptions["№ ИБ"].FirstOrDefault(x => x.Item1 == item.MedicalHistoryNumber).Item2)
                    continue;

                if (!FilterOptions["Отделение"].FirstOrDefault(x => x.Item1 == item.MainDepartmentName).Item2)
                    continue;

                if (!FilterOptions["Отделение по разноске"].FirstOrDefault(x => x.Item1 == item.DepartmentName).Item2)
                    continue;

                if (!FilterOptions["Архив"].FirstOrDefault(x => x.Item1 == item.ArchiveName).Item2)
                    continue;

                if (!FilterOptions["Экспертиза"].FirstOrDefault(x => x.Item1 == (item.Expertise ? "Да" : "Нет")).Item2)
                    continue;

                filtered.Add(item);
            }
            return filtered.OrderByDescending(x => x.DateDeath).ToList();
        }

        public void SwitchCheckBox(string key, string value, bool status)
        {
            int index = FilterOptions[key].IndexOf((value, !status));
            FilterOptions[key].RemoveAt(index);
            FilterOptions[key].Insert(index, (value, status));
        }

        public void SwitchAllCheckBox(string key, bool status)
        {
            foreach (var item in FilterOptions[key].ToList())
            {
                FilterOptions[key].Remove(item);
                FilterOptions[key].Add((item.Item1, status));
            }
        }

        public bool HasAnyFilterOptionFalse()
        {
            foreach (var filterList in FilterOptions.Values)
            {
                if (filterList.Any(option => !option.Item2))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasAnyFilterOptionFalse(string key)
        {
            if (FilterOptions[key].Any(x => !x.Item2))
                return true;
            return false;
        }

        public void SetFilter(List<Patient> obj)
        {
            SetBaseOptions();
            foreach (var item in obj)
            {
                if (!FilterOptions["Фамилия"].Contains((item.Lastname, true)))
                {
                    FilterOptions["Фамилия"].Add((item.Lastname, true));
                }
                if (!FilterOptions["Имя"].Contains((item.Firstname, true)))
                {
                    FilterOptions["Имя"].Add((item.Firstname, true));
                }
                if (!FilterOptions["Отчество"].Contains((item.Surname, true)))
                {
                    FilterOptions["Отчество"].Add((item.Surname, true));
                }
                if (!FilterOptions["№ ИБ"].Contains((item.MedicalHistoryNumber, true)))
                {
                    FilterOptions["№ ИБ"].Add((item.MedicalHistoryNumber, true));
                }
                if (!FilterOptions["Отделение"].Contains((item.MainDepartmentName, true)))
                {
                    FilterOptions["Отделение"].Add((item.MainDepartmentName, true));
                }
                if (!FilterOptions["Отделение по разноске"].Contains((item.DepartmentName, true)))
                {
                    FilterOptions["Отделение по разноске"].Add((item.DepartmentName, true));
                }
                if (!FilterOptions["Архив"].Contains((item.ArchiveName, true)))
                {
                    FilterOptions["Архив"].Add((item.ArchiveName, true));
                }
            }
        }

        public void CheckExistsInFilterOptions(List<Patient> obj)
        {
            foreach (var item in obj)
            {
                AddFilterOption(item);
            }
        }

        public void AddFilterOption(Patient obj)
        {
            if (!FilterOptions["Фамилия"].Select(x => x.Item1).Contains(obj.Lastname))
            {
                FilterOptions["Фамилия"].Add((obj.Lastname, true));
            }
            if (!FilterOptions["Имя"].Select(x => x.Item1).Contains(obj.Firstname))
            {
                FilterOptions["Имя"].Add((obj.Firstname, true));
            }
            if (!FilterOptions["Отчество"].Select(x => x.Item1).Contains(obj.Surname))
            {
                FilterOptions["Отчество"].Add((obj.Surname, true));
            }
            if (!FilterOptions["№ ИБ"].Select(x => x.Item1).Contains(obj.MedicalHistoryNumber))
            {
                FilterOptions["№ ИБ"].Add((obj.MedicalHistoryNumber, true));
            }
            if (!FilterOptions["Отделение"].Select(x => x.Item1).Contains(obj.MainDepartmentName))
            {
                FilterOptions["Отделение"].Add((obj.MainDepartmentName, true));
            }
            if (!FilterOptions["Отделение по разноске"].Select(x => x.Item1).Contains(obj.DepartmentName))
            {
                FilterOptions["Отделение по разноске"].Add((obj.DepartmentName, true));
            }
            if (!FilterOptions["Архив"].Select(x => x.Item1).Contains(obj.ArchiveName))
            {
                FilterOptions["Архив"].Add((obj.ArchiveName, true));
            }
        }

        public List<(string, bool)> GetFilterValue(string key)
        {
            if (FilterOptions.ContainsKey(key))
                return FilterOptions[key];
            return new();
        }

        private void SetBaseOptions()
        {
            FilterOptions = new()
            {
                { "Вскрытие" , new() { ("Нет", true), ("ПАО", true), ("СМЭ", true) } },
                { "ОНКО" , new() { ("Нет", true), ("Да", true) } },
                { "Фамилия" , new() },
                { "Имя" , new() },
                { "Отчество" , new() },
                { "№ ИБ" , new() },
                { "Отделение" , new() },
                { "Отделение по разноске" , new() },
                { "Архив", new() },
                { "Экспертиза" , new() { ("Нет", true), ("Да", true) } }
            };
        }
    }
}
