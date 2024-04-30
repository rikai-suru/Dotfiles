// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
// @ts-ignore
import Network from "resource:///com/github/Aylur/ags/service/network.js";
import {symbolic_strength} from "../../utils";

const network_revealer = Widget.Revealer({
    transition: "slide_left",
    transitionDuration: 500,
    css: "padding-left: 5px;", // add padding when shown
    child: Widget.Label({
        label: Network.wifi.bind("ssid").transform(ssid => ssid || "Offline"),
    }),
});

export const BarNetworkInfo = Widget.EventBox({
    class_name: "network",
    on_primary_click: () => network_revealer.reveal_child = !network_revealer.reveal_child,
    // on_hover: () => network_revealer.reveal_child = true,
    // on_hover_lost: () => network_revealer.reveal_child = false,
    child: Widget.Box({
        children: [
            Widget.Label({
                class_name: "disconnected", // disconnected initially
            }).hook(Network, widget => {
                if (!Network.wifi || !Network.wired)
                    return;

                widget.class_name = Network.wifi.internet;

                if (Network.primary === "wired")
                    widget.label = " ";

                else if (Network.wifi.internet === "connected")
                    widget.label = symbolic_strength({
                        value: Network.wifi.strength,
                        array: ["󰤯 ", "󰤟 ", "󰤢 ", "󰤥 "],
                    });

                else if (Network.wifi.internet === "connecting")
                    widget.label = symbolic_strength({
                        value: Network.wifi.strength,
                        array: ["󰤫 ", "󰤠 ", "󰤣 ", "󰤦 "],
                    });

                else
                    widget.label = "󰤭 ";
            }),
            network_revealer,
        ],
    }),
});
