const copyClipboard = async (text = "", callback = null) => {
    try {
        await navigator.clipboard.writeText(text);

        //  Cek callback tersebut tidak null
        if (callback !== null && typeof callback === "function") {
            // Panggil callback function dengan text sebagai argumen
            callback(text);
        }
    } catch (err) {
        console.error("Copy clipboard failed!" + err);
    }
};
