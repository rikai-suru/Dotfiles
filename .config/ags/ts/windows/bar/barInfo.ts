import {BarWidget} from "./barWidget";
import {BarClock} from "./barClock";
import {BarNetworkInfo} from "./barNetwork";
import {BarBatteryInfo} from "./barBattery";

export const BarInfo = BarWidget({
    class_name: "info",
    eventbox: {
        on_secondary_click: () => WindowHandler.toggle_window("glance"),
    },
    box: {
        spacing: 10,
        children: [
            BarBatteryInfo,
            BarNetworkInfo,
            BarClock,
        ],
    },
});
