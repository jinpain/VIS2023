function htmlToDoc(id, fileName) {
    var htmlContent = document.getElementById(id).innerHTML;
    var parser = new DOMParser();
    var doc = parser.parseFromString(htmlContent, 'text/html');

    var link = document.createElement('a');
    link.href = URL.createObjectURL(new Blob([doc.documentElement.outerHTML], { type: 'application/msword' }));
    link.download = fileName + ".docx";
    link.style.display = 'none';

    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    URL.revokeObjectURL(link.href);
}

function htmlTableToExcel() {
    const data = document.getElementById('tblToExcl');
    const ws = XLSX.utils.table_to_sheet(data);

    formatColumnDate(ws, 6, 'dd.mm.yyyy hh:mm');
    formatColumnDate(ws, 8, 'dd.mm.yyyy');
    formatColumnDate(ws, 9, 'dd.mm.yyyy');
    formatColumnDate(ws, 10, 'dd.mm.yyyy');
    formatColumnDate(ws, 11, 'dd.mm.yyyy');
    formatColumnDate(ws, 12, 'dd.mm.yyyy');
    formatColumnDate(ws, 13, 'dd.mm.yyyy');

    const wb = XLSX.utils.book_new();
    XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');
    XLSX.writeFile(wb, 'ExportedFile.xlsx');
}

function formatColumnDate(ws, column, format) {
    var range = XLSX.utils.decode_range(ws['!ref']);
    for (var i = range.s.r + 1; i <= range.e.r; i++) {
        var cellAddress = XLSX.utils.encode_cell({ r: i, c: column });
        if (ws[cellAddress]) {

            let dateString = ws[cellAddress].v;

            if (dateString == "") {
                continue;
            }

            let newDate;

            const dateObject = XLSX.SSF.parse_date_code(dateString);
            if (dateObject['y'] != 1900) {
                newDate = new Date(dateObject['y'], (dateObject['d'] - 1), dateObject['m'], dateObject['H'], dateObject['M']);
            }
            else {
                const [datePart, timePart] = dateString.split(' ');
                const [day, month, year] = datePart.split('.');
                if (timePart != undefined) {
                    const [hours, minutes] = timePart.split(':');
                    newDate = new Date(year, month - 1, day, hours, minutes);
                } else {
                    newDate = new Date(year, month - 1, day);
                }
            }

            if (isNaN(newDate.getTime())) {
                ws[cellAddress].v = dateString; // Устанавливаем новое значение даты
            } else {
                ws[cellAddress].t = 'd'; // Устанавливаем тип ячейки как дата
                ws[cellAddress].z = format; // Устанавливаем формат ячейки
                ws[cellAddress].v = newDate; // Устанавливаем новое значение даты
            }
        }
    }
}