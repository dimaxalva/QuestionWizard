﻿(function () {
    window.QuillFunctions = {
        createQuill: function (quillElement, hasToolbar) {
            var options = {
                debug: 'info',
                modules: {
                    toolbar: hasToolbar ? toolbarOptions : false
                },
                placeholder: 'This ... has no content',
                readOnly: false,
                theme: 'snow',
                bounds: quillElement
            };

            new Quill(quillElement, options);
        },

        getQuillContent: function (quillControl) {
            return JSON.stringify(quillControl.__quill.getContents());
        },
        setQuillContent: function (quillControl, quillContent) {
            content = JSON.parse(quillContent);
            return quillControl.__quill.SetContents(content, 'api');
        },
        disableQuillEditor: function (quillControl) {
            quillControl.__quill.enable(false);
        }
    };
})();

var toolbarOptions = [
    // Toggled buttons.
    ['bold', 'italic', 'underline', 'strike'],
    ['blockquote', 'code-block'],

    // Custom button values.
    [{ 'header': 1 }, { 'header': 2 }],
    [{ 'list': 'ordered' }, { 'list': 'bullet' }],

    // Superscript and subscript.
    [{ 'script': 'sub' }, { 'script': 'super' }],

    // Outdent and indent.
    [{ 'indent': '-1' }, { 'indent': '+1' }],

    // Text direction.
    [{ 'direction': 'rtl' }],

    // Custom dropdown.
    [{ 'size': ['small', false, 'large', 'huge'] }],
    [{ 'header': [1, 2, 3, 4, 5, 6, false] }],

    // Dropdown with defaults from theme.
    [{ 'color': [] }, { 'background': [] }],
    [{ 'font': [] }],
    [{ 'align': [] }],

    // Links, upload image and append video buttons.
    ['link', 'image', 'video'],

    // Remove formatting button.
    ['clean']
];