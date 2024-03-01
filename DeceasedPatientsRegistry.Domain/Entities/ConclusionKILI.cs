namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class ConclusionKILI
    {
        public Guid Id { get; set; }
        //Указать, кем и когда допущен дефект
        public string? WhoMadeDefect { get; set; }
        //Указать, причину дефекта
        public string? CauseDefect { get; set; }
        //Связь дефектов с наступлением летального исхода
        public string? ConnectionDefectAndDeath { get; set; }
        //Решение КИЛИ
        public string? SolutionKILI { get; set; }
        //Рекомендации КИЛИ
        public string? RecommendationsKILI { get; set; }
    }
}
