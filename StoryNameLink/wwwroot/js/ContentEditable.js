window.contentEditable = {
    getText: function (elementId) {
        return document.getElementById(elementId).innerText;
    },
    setTextChangedCallback: function (elementId, text) {
        document.getElementById(elementId).innerText = text.length;
        document.getElementById(elementId).onclick = function () {
            DotNet.invokeMethodAsync('StoryNameLink', 'ShowEdit');
        };
    },
    setFocus: function (elementId) {
        const range = document.createRange();
        range.selectNodeContents(document.getElementById(elementId));
        range.collapse(false);
        const sel = window.getSelection();
        sel.removeAllRanges();
        sel.addRange(range);
    }
};