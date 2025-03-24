window.monacoInterop = {
    loadMonaco: async function (elementId) {
        if (!window.require) {
            console.error("Monaco Editor loader is missing!");
            return;
        }

        require.config({ paths: { 'vs': 'https://cdnjs.cloudflare.com/ajax/libs/monaco-editor/0.33.0/min/vs' } });

        require(["vs/editor/editor.main"], function () {
            window.editor = monaco.editor.create(document.getElementById(elementId), {
                value: "// Write your code here...",
                language: "csharp",
                theme: "vs-dark",
                automaticLayout: true
            });
        });
    },

    getContent: function () {
        return window.editor ? window.editor.getValue() : "";
    },

    setContent: function (content) {
        if (window.editor) {
            window.editor.setValue(content);
        }
    }
};
