namespace DeceasedPatientsRegistry.Domain
{
    public class Enums
    {
        public enum AutopsyType
        {
            Нет,
            ПАО,
            СМЭ
        }
        public enum LocationMedicalHistory
        {
            Архив,
            ККМП,
            КИЛИ
        }
        public enum ActionType
        {
            Добавил,
            Обновил,
            Удалил,
            Восстановил
        }
    }
}
