// @ts-ignore
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";
import { BarWidget } from "./barWidget";
import { BarSysTray } from "./barSysTray";

export const BarSysInfo = BarWidget({
    class_name: "sysinfo",
    eventbox: {
        on_primary_click: () => BarSysTray.reveal_child = !BarSysTray.reveal_child,
        on_middle_click: () => App.Inspector(),
    },
    box: {
        spacing: 12,
        children: [
            Widget.Label(" 0.0G").poll(5000, widget => Utils.execAsync(["bash", "-c", "free -hg | awk 'NR == 2 {print $3}' | awk '{printf \"%5.1fG\", $1}'"])
                .then(out => widget.label = ` ${out}`),
            ),
            Widget.Label(" 0.0%").poll(5000, widget => Utils.execAsync(["bash", "-c", "top -bn1 | sed -n '/Cpu/p' | awk '{print $4}' | sed 's/..,//'"])
                .then(out => widget.label = ` ${out}%`),
            ),
        ],
    },
});
