namespace DeceasedPatientsRegistry.Shared.ModalWindows.PatientModalChild
{
    public class SaveStatus
    {
        public bool SaveButtonStatus { get; private set; }
        public bool ReportChanged { get; private set; }
        public bool PatientChanged { get; private set; }
        public bool ArchiveChanged { get; private set; }
        public bool KKMPChanged { get; private set; }
        public bool KILIChanged { get; private set; }
        public bool ConclusionKILIChanged { get; private set; }

        public void MarkReportChanged()
        {
            ReportChanged = true;
            EnableSaveButton();
        }

        public void MarkPatientChanged()
        {
            PatientChanged = true;
            EnableSaveButton();
        }

        public void MarkArchiveChanged()
        {
            ArchiveChanged = true;
            EnableSaveButton();
        }

        public void MarkKKMPChanged()
        {
            KKMPChanged = true;
            EnableSaveButton();
        }
        public void MarkKILIChanged()
        {
            KILIChanged = true;
            EnableSaveButton();
        }

        public void MarkConclusionKILIChanged()
        {
            ConclusionKILIChanged = true;
            EnableSaveButton();
        }

        private void EnableSaveButton() => SaveButtonStatus = true;

        public void Clear()
        {
            SaveButtonStatus = false;
            ReportChanged = false;
            PatientChanged = false;
            ArchiveChanged = false;
            KKMPChanged = false;
            KILIChanged = false;
            ConclusionKILIChanged = false;
        }
    }
}
