// @ts-ignore
import SystemTray from "resource:///com/github/Aylur/ags/service/systemtray.js";
// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
// import SystemTray from "resource:///com/github/Aylur/ags/service/systemtray.js";
import {BarWidget} from "./barWidget";

export const BarSysTray = Widget.Revealer({
    transition: "slide_left",
    transitionDuration: 500,
    child: BarWidget({
        class_name: "systray",
        box: {
            children: SystemTray.bind("items").transform(items => {
                return items.map(item => Widget.Button({
                    on_primary_click: () => item.openMenu(null),
                    child: Widget.Icon({
                        icon: item.bind("icon"),
                        size: 18,
                    }),
                }));
            }),
        },
    }),
});
