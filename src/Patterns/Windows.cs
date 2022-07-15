// Copyright (c) Arctium.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Arctium.WoW.Launcher.Patterns;

static class Windows
{
#if x64
    public static short[] Init = { 0xC7, 0x05, -1, -1, -1, -1, 0x01, 0x00, 0x00, 0x00, 0x48, 0x8D, -1, -1, -1, -1, -1, 0x48, 0x8D, -1, -1, -1, -1, -1, 0xE8, -1, -1, -1, -1, 0x85 };

    // Anti Crash.
    public static short[] Integrity = { 0x44, 0x89, -1, 0x24, -1, 0x44, 0x89, -1, 0x24, -1, 0x89, -1, 0x24, -1, 0x48, 0x89, -1, 0x24, -1, 0x53, 0x56, 0x57 };
    public static short[] Integrity2 = { 0x44, 0x89, -1, 0x24, -1, 0x44, 0x89, -1, 0x24, -1, 0x89, -1, 0x24, -1, 0x48, 0x89, -1, 0x24, -1, 0x53, 0x57 };
    public static short[] Remap = { 0x48, -1, -1, 0x1E, 0x0F, 0x83 };

    // Certificate bundle loading.
    public static short[] CertBundle = { 0x75, 0x06, 0x48, -1, -1, 0x70, 0x5E, 0xC3 };
    public static short[] CertCommonName = { 0xFF, 0xB0, 0x01, 0xEB, 0x02, 0x32, 0xC0, 0x48, 0x8B, 0x9C, 0x24, 0xB8, 0x00 };

    public static short[] DisableED25519 = { 0x85, 0xC0, 0x75, 0x04, 0xB0, 0x01, 0xEB, 0x02, 0x32, 0xC0, 0x4C, 0x8D };

    // Custom files (mods).
    public static short[] LoadByFileId = { 0x41, -1, -1, 0x01, 0x0F, 0x84, -1, 0x00, 0x00, 0x00, 0x48, 0x8B, -1, -1, -1, -1, -1, 0x8B };
    public static short[] LoadByFilePath = { 0x01, 0x0F, 0x84, -1, -1, -1, -1, 0x48, 0x8B, -1, -1, -1, -1, -1, 0x44, 0x89, -1, -1, -1, 0x48, 0x85, 0xC9 };
    public static short[] CustomFileIdHook = { 0x48, 0x89, 0x5C, 0x24, 0x08, 0x57, 0x48, 0x83, 0xEC, 0x20, 0x48, 0x8B, -1, 0x48, -1, -1, 0x48, -1, -1, -1, -1, -1, -1, 0xE8, -1, -1, -1, -1, 0x48, -1, -1, -1, -1, -1, -1, 0x48, -1, -1, 0x74, -1, 0x48, -1, 0xCD };
#elif ARM64
    // Anti Crash.
    public static short[] Integrity = { };
    public static short[] Integrity2 = { };
    public static short[] Remap = { };

    // Certificate bundle loading.
    public static short[] CertBundle = { 0xA0, 0xA0, -1, -1, 0x80, 0x02, -1, -1, -1, -1, -1, 0x97 };
    public static short[] CertCommonName = { 0x00, -1, -1, -1, 0xFF, 0x54, 0x00, 0x00, 0x80, 0x52, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0xC0, 0x03, -1, -1, -1, -1, -1, 0xEB };
#endif

    // Registry entry used for -launcherlogin.
    public static short[] LauncherLogin = @"Software\Blizzard Entertainment\Battle.net\Launch Options\".ToPattern();
}
