import App from "resource:///com/github/Aylur/ags/app.js"
import * as Utils from "resource:///com/github/Aylur/ags/utils.js"

Utils.monitorFile(
    // directory that contains the scss files
    `${App.configDir}/css/_colors.scss`,
    // reload function
    function() {
        // main scss file
        const scss = `${App.configDir}/style.scss`;
        // target css file
        const css = `${App.configDir}/style.css`;
        // compile, reset, apply
        Utils.exec(`sass ${scss} ${css}`);
        App.resetCss();
        App.applyCss(css);
    },
)

Utils.monitorFile(
    // directory that contains the scss files
    `${App.configDir}/css/docked_bar.scss`,
    // reload function
    function() {
        // main scss file
        const scss = `${App.configDir}/style.scss`;
        // target css file
        const css = `${App.configDir}/style.css`;
        // compile, reset, apply
        Utils.exec(`sass ${scss} ${css}`);
        App.resetCss();
        App.applyCss(css);
    },
)

Utils.monitorFile(
    // directory that contains the scss files
    `${App.configDir}/css/floating_bar.scss`,
    // reload function
    function() {
        // main scss file
        const scss = `${App.configDir}/style.scss`;
        // target css file
        const css = `${App.configDir}/style.css`;
        // compile, reset, apply
        Utils.exec(`sass ${scss} ${css}`);
        App.resetCss();
        App.applyCss(css);
    },
)

Utils.monitorFile(
    // directory that contains the scss files
    `${App.configDir}/style.scss`,
    // reload function
    function() {
        // main scss file
        const scss = `${App.configDir}/style.scss`;
        // target css file
        const css = `${App.configDir}/style.css`;
        // compile, reset, apply
        Utils.exec(`sass ${scss} ${css}`);
        App.resetCss();
        App.applyCss(css);
    },
)

// // build scss
await Utils.execAsync([
    "sass",
    App.configDir + "/style.scss",
    App.configDir + "/style.css",
]);

await Utils.execAsync([
    "bun", "build", `${App.configDir}/ts/main.ts`,
    "--outdir", "/tmp/ags/js",
    "--external", "resource:///*",
    "--external", "gi://*",
    "--external", "cairo",
]).catch(console.error);

const main = await import(`file:///tmp/ags/js/main.js`);
export default main.default;

// config.js -> /ts/main.ts
