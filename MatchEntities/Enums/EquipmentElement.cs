using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities.Enums
{
    /// <summary>
    /// Copied from DemoInfo. Keep in sync when applying changes to either of them.
    /// </summary>
    public enum EquipmentElement : short
    {
        Unknown = 0,
        P2000 = 1,
        Glock = 2,
        P250 = 3,
        Deagle = 4,
        FiveSeven = 5,
        DualBarettas = 6,
        Tec9 = 7,
        CZ = 8,
        USP = 9,
        Revolver = 10, // 0x0000000A
        MP7 = 101, // 0x00000065
        MP9 = 102, // 0x00000066
        Bizon = 103, // 0x00000067
        Mac10 = 104, // 0x00000068
        UMP = 105, // 0x00000069
        P90 = 106, // 0x0000006A
        MP5SD = 107, // 0x0000006B
        SawedOff = 201, // 0x000000C9
        Nova = 202, // 0x000000CA
        Swag7 = 203, // 0x000000CB
        XM1014 = 204, // 0x000000CC
        M249 = 205, // 0x000000CD
        Negev = 206, // 0x000000CE
        Gallil = 301, // 0x0000012D
        Famas = 302, // 0x0000012E
        AK47 = 303, // 0x0000012F
        M4A4 = 304, // 0x00000130
        M4A1 = 305, // 0x00000131
        Scout = 306, // 0x00000132
        SG556 = 307, // 0x00000133
        AUG = 308, // 0x00000134
        AWP = 309, // 0x00000135
        Scar20 = 310, // 0x00000136
        G3SG1 = 311, // 0x00000137
        Zeus = 401, // 0x00000191
        Kevlar = 402, // 0x00000192
        Helmet = 403, // 0x00000193
        Bomb = 404, // 0x00000194
        Knife = 405, // 0x00000195
        DefuseKit = 406, // 0x00000196
        World = 407, // 0x00000197
        Decoy = 501, // 0x000001F5
        Molotov = 502, // 0x000001F6
        Incendiary = 503, // 0x000001F7
        Flash = 504, // 0x000001F8
        Smoke = 505, // 0x000001F9
        HE = 506, // 0x000001FA
    }
}
