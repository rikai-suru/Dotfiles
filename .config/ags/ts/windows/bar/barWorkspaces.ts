// @ts-ignore
const hyprland = await Service.import('hyprland')
import * as Widget from "resource:///com/github/Aylur/ags/widget.js";


import { BarWidget } from "./barWidget";

export const BarWorkspaces = BarWidget({
    class_name: "workspaces",
    box: {
        spacing: 20,
        setup: widget => {
            widget.hook(hyprland, widget => {
                // persistent workspaces
                const workspaces = [
                    { id: 1, glyph: " " },
                    { id: 2, glyph: " " },
                    { id: 3, glyph: " " },
                    { id: 4, glyph: " " },
                    { id: 5, glyph: " " },
                    { id: 6, glyph: " " },
                    { id: 7, glyph: " " },
                    { id: 8, glyph: " " },
                    { id: 9, glyph: "󰽟 " },
                    { id: 10, glyph: " " },
                    { id: 11, glyph: "󰼏 " },
                    { id: 12, glyph: "󰼐 " },
                    { id: 13, glyph: "󰼑 " },
                ];

                // creates a new array containing occupied hyprland workspaces
                // id
                let occupied_workspaces = hyprland.workspaces.map(obj => ({ id: obj.id }));
                // console.log(occupied_workspaces);

                hyprland.workspaces
                    .sort((a, b) => a.id - b.id)
                    // named workspaces have negative indices
                    .filter(ws => ws.id > workspaces[workspaces.length - 1].id)
                    .forEach(ws => workspaces.push({ id: ws.id, glyph: "" }));

                widget.children = workspaces.map(ws => {
                    return Widget.Button({
                        // basically, there's three states: active, occupied, or empty.
                        class_name: ws.id === hyprland.active.workspace.id ? "active" : (occupied_workspaces.some(item => item.id === ws.id) ? "occupied" : "empty"),
                        child: Widget.Label({ label: ws.glyph }), // Corrected this line
                        on_primary_click: () => Utils.execAsync(`hyprctl dispatch workspace ${ws.id}`)
                    });
                });
            });
        },
    },
});


// function className (input: id): string {
//     // Hyprland.active.workspace.id == ws.id ? "active" : "active"
//     const result = input * 2;
//
//     const resultString = result.toString();
//
//     return resultString;
// }
