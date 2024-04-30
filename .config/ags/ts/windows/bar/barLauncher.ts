// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
import { BarWidget} from "./barWidget";

const launcher_revealer = Widget.Revealer({
    transition: "slide_left",
    transitionDuration: 500,
    child: Widget.Label("Run"),
    css: "padding-left: 10px;", // add padding when shown
});

export const BarLauncher = BarWidget({
    class_name: "launcher",
    eventbox: {
        // on_primary_click: () => Utils.execAsync(["pkill", "rofi"])
        //     .catch(() => Utils.execAsync(["rofi", "-show", "drun"]))
        //     .catch(() => undefined),
        on_primary_click: () => launcher_revealer.reveal_child = !launcher_revealer.reveal_child,
        // on_hover: () => launcher_revealer.reveal_child = true,
        // on_hover_lost: () => launcher_revealer.reveal_child = false,
    },
    box: {
        children: [
            Widget.Icon({
                icon: "/home/rikai/.config/ags/assets/launcher.png",
                size: 16,
            }),
            launcher_revealer,
        ],
    },
});
