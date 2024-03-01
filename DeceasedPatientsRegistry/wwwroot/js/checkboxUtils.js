function toggleAllCheckedAttribute(className, status) {
    var elements = document.getElementsByClassName(className);
    for (var i = 0; i < elements.length; i++) {
        if (status) {
            elements[i].setAttribute("checked", "true");
        }
        else {
            if (elements[i].hasAttribute("checked")) {
                elements[i].removeAttribute("checked");
            }
        }
    }
}
