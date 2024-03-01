function callPrint(id) {
    var element = document.getElementById(id);
    var htmlToPrint = element.outerHTML;
    var windowPrint = window.open('', '', 'left=10,top=10,width=800,height=640,toolbar=0,scrollbars=1,status=0');
    windowPrint.document.write(htmlToPrint);
    windowPrint.document.close();
    windowPrint.focus();
    windowPrint.print();
    windowPrint.close();
}
