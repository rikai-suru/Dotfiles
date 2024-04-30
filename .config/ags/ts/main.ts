import App from "resource:///com/github/Aylur/ags/app.js";
import WindowHandler from "./window.js";

export default {
    style: App.configDir + "/style.css",
    windows: [
        WindowHandler.spawn_window("bar"),
        // WindowHandler.spawn_window("banana"),
    ],
};
