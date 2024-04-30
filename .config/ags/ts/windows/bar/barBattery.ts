// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
// @ts-ignore
import Battery from "resource:///com/github/Aylur/ags/service/battery.js";
import {symbolic_strength} from "../../utils";
import Brightness from "../../services/brightness";

const battery_revealer = Widget.Revealer({
    transition: "slide_left",
    transitionDuration: 500,
    css: "padding-left: 5px;", // add padding when shown
    child: Widget.Label({
        label: Battery.bind("percent").transform(percent => `${percent.toString()}%`),
    }),
});

export const BarBatteryInfo = Widget.EventBox({
    class_name: "battery",
    on_scroll_up: () => Brightness.screen_value += 0.1,
    on_scroll_down: () => Brightness.screen_value -= 0.1,
    on_primary_click: () => battery_revealer.reveal_child = !battery_revealer.reveal_child,
    // on_hover: () => battery_revealer.reveal_child = true,
    // on_hover_lost: () => battery_revealer.reveal_child = false,
    child: Widget.Box({
        children: [
            Widget.Label({
                class_name: "glyph",
                setup: widget => {
                    widget.hook(Battery, widget => {
                        if (Battery.percent < 0) // -1 is an odd default choice but ok
                            return;

                        widget.label = symbolic_strength({
                            value: Battery.percent,
                            array: [" ", " ", " ", " ", " "],
                        });
                    });
                },
            }),
            battery_revealer,
        ],
    }),
});
