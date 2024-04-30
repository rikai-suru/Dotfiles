import WindowHandler from "../../window.js";
// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
// import Mpris from "resource:///com/github/Aylur/ags/service/mpris.js";
// import Audio from "resource:///com/github/Aylur/ags/service/audio.js";
// import Bluetooth from "resource:///com/github/Aylur/ags/service/bluetooth.js";

// Bar Widgets
import { BarWorkspaces } from "./barWorkspaces";
import { BarLauncher } from "./barLauncher";
import { BarSysTray } from "./barSysTray";
import { BarSysInfo } from "./barSysInfo";
import {BarInfo} from "./barInfo";

export default () => Widget.Window({
    name: "bar",
    anchor: ["top", "left", "right"],
    exclusivity: "exclusive",
    child: Widget.CenterBox({
        class_name: "bar",
        start_widget: Widget.Box({
            spacing: 10,
            hpack: "start",
            children: [
                // BarLauncher,
                BarWorkspaces,
            ],
        }),
        // center_widget: Widget.Box({
        //     spacing: 10,
        //     hpack: "center",
        //     children: [
        //         BarPlayer,
        //     ],
        // }),
        end_widget: Widget.Box({
            spacing: 10,
            hpack: "end",
            children: [
                // BarMedia,
                BarSysTray,
                BarSysInfo,
                BarInfo,
                // BarPower,
            ],
        }),
    }),
});
