﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Frameworks
{
    public sealed class DefaultFrameworkMappings : IFrameworkMappings
    {
        public DefaultFrameworkMappings()
        {

        }

        private static KeyValuePair<string, string>[] _identifierSynonyms;
        public IEnumerable<KeyValuePair<string, string>> IdentifierSynonyms
        {
            get
            {
                if (_identifierSynonyms == null)
                {
                    _identifierSynonyms = new KeyValuePair<string, string>[]
                    {
                        // .NET
                        new KeyValuePair<string, string>("NETFramework", FrameworkConstants.FrameworkIdentifiers.Net),
                        new KeyValuePair<string, string>(".NET", FrameworkConstants.FrameworkIdentifiers.Net),

                        // .NET Core
                        new KeyValuePair<string, string>("NETCore", FrameworkConstants.FrameworkIdentifiers.NetCore),

                        // Portable
                        new KeyValuePair<string, string>("NETPortable", FrameworkConstants.FrameworkIdentifiers.Portable),

                        // ASP
                        new KeyValuePair<string, string>("asp.net", FrameworkConstants.FrameworkIdentifiers.AspNet),
                        new KeyValuePair<string, string>("asp.netcore", FrameworkConstants.FrameworkIdentifiers.AspNetCore),

                        // Mono/Xamarin
                        new KeyValuePair<string, string>("Xamarin.PlayStationThree", FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation3),
                        new KeyValuePair<string, string>("XamarinPlayStationThree", FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation3),
                        new KeyValuePair<string, string>("Xamarin.PlayStationFour", FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation4),
                        new KeyValuePair<string, string>("XamarinPlayStationFour", FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation4),
                        new KeyValuePair<string, string>("XamarinPlayStationVita", FrameworkConstants.FrameworkIdentifiers.XamarinPlayStationVita),
                    };
                }

                return _identifierSynonyms;
            }
        }

        private static KeyValuePair<string, string>[] _identifierShortNames;
        public IEnumerable<KeyValuePair<string, string>> IdentifierShortNames
        {
            get
            {
                if (_identifierShortNames == null)
                {
                    _identifierShortNames = new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Net, "net"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, "nfcore"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.NetMicro, "netmf"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Silverlight, "sl"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Portable, "portable"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.WindowsPhone, "wp"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.WindowsPhoneApp, "wpa"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Windows, "win"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.AspNet, "aspnet"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.AspNetCore, "aspnetcore"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Native, "native"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.MonoAndroid, "monoandroid"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.MonoTouch, "monotouch"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.MonoMac, "monomac"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinIOs, "xamarinios"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinMac, "xamarinmac"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation3, "xamarinpsthree"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinPlayStation4, "xamarinpsfour"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinPlayStationVita, "xamarinpsvita"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinXbox360, "xamarinxboxthreesixty"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.XamarinXboxOne, "xamarinxboxone"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Dnx, "dnx"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.DnxCore, "dnxcore"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.CoreCLR, "core"),
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.NetCore, "netcore"),   // legacy
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.WinRT, "winrt"),       // legacy
                    };
                }

                return _identifierShortNames;
            }
        }

        private static FrameworkSpecificMapping[] _profileShortNames;
        public IEnumerable<FrameworkSpecificMapping> ProfileShortNames
        {
            get
            {
                if (_profileShortNames == null)
                {
                    _profileShortNames = new FrameworkSpecificMapping[]
                    {
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Net, "Client", "Client"),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Net, "CF", "CompactFramework"),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Net, "Full", string.Empty),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Silverlight, "WP", "WindowsPhone"),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Silverlight, "WP71", "WindowsPhone71"),
                    };
                }

                return _profileShortNames;
            }
        }

        private static KeyValuePair<NuGetFramework, NuGetFramework>[] _equivalentFrameworks;
        public IEnumerable<KeyValuePair<NuGetFramework, NuGetFramework>> EquivalentFrameworks
        {
            get
            {
                if (_equivalentFrameworks == null)
                {
                    _equivalentFrameworks = new KeyValuePair<NuGetFramework, NuGetFramework>[]
                    {
                        // win <-> win8
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Windows, FrameworkConstants.EmptyVersion),
                                                    FrameworkConstants.CommonFrameworks.Win8),

                        // win8 <-> f:netcore45 p:win8
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Win8,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, new Version(4, 5, 0, 0),
                                                        FrameworkConstants.PlatformIdentifiers.Windows, new Version(8, 0, 0, 0))),

                        // win81 <-> f:netcore451 p:win81
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Win81,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, new Version(4, 5, 1, 0),
                                                        FrameworkConstants.PlatformIdentifiers.Windows, new Version(8, 1, 0, 0))),

                        // win8 <-> netcore45
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Win8,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, new Version(4, 5, 0, 0))),

                        // netcore45 <-> winrt45
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, new Version(4, 5, 0, 0)),
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WinRT, new Version(4, 5, 0, 0))),

                        // netcore <-> netcore45
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, FrameworkConstants.EmptyVersion),
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, new Version(4, 5, 0, 0))),

                        // winrt <-> winrt45
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WinRT, FrameworkConstants.EmptyVersion),
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WinRT, new Version(4, 5, 0, 0))),

                        // win81 <-> netcore451
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Win81,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, new Version(4, 5, 1, 0))),

                        // wp <-> wp7
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WindowsPhone, FrameworkConstants.EmptyVersion),
                                                    FrameworkConstants.CommonFrameworks.WP7),

                        // wp7 <-> f:sl3-wp
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.WP7,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Silverlight, new Version(3, 0, 0, 0), "WindowsPhone")),

                        // wp71 <-> f:sl4-wp71
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WindowsPhone, new Version(7, 1, 0, 0)),
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Silverlight, new Version(4, 0, 0, 0), "WindowsPhone71")),

                        // wp8 <-> f:sl8-wp
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.WP8,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Silverlight, new Version(8, 0, 0, 0), "WindowsPhone")),

                        // wp81 <-> f:sl81-wp
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.WP81,
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Silverlight, new Version(8, 1, 0, 0), "WindowsPhone")),

                        // wpa <-> wpa81
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WindowsPhoneApp, FrameworkConstants.EmptyVersion),
                                                    FrameworkConstants.CommonFrameworks.WPA81),

                        // dnx <-> dnx451
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Dnx,
                                                    FrameworkConstants.CommonFrameworks.Dnx451),

                        // dnxcore <-> dnxcore50
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.DnxCore,
                                                    FrameworkConstants.CommonFrameworks.DnxCore50),

                        // core <-> core50
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.Core,
                                                    FrameworkConstants.CommonFrameworks.Core50),

                        // TODO: remove these rules post-RC
                        // aspnet <-> aspnet50
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.AspNet,
                                                    FrameworkConstants.CommonFrameworks.AspNet50),

                        // aspnetcore <-> aspnetcore50
                        new KeyValuePair<NuGetFramework, NuGetFramework>(
                                                    FrameworkConstants.CommonFrameworks.AspNetCore,
                                                    FrameworkConstants.CommonFrameworks.AspNetCore50),
                    };
                }

                return _equivalentFrameworks;
            }
        }

        private static FrameworkSpecificMapping[] _equivalentProfiles;
        public IEnumerable<FrameworkSpecificMapping> EquivalentProfiles
        {
            get
            {
                if (_equivalentProfiles == null)
                {
                    _equivalentProfiles = new FrameworkSpecificMapping[] {
                        // The client profile, for the purposes of NuGet, is the same as the full framework
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Net, "Client", string.Empty),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Net, "Full", string.Empty),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.Silverlight, "WindowsPhone71", "WindowsPhone"),
                        new FrameworkSpecificMapping(FrameworkConstants.FrameworkIdentifiers.WindowsPhone, "WindowsPhone71", "WindowsPhone"),
                    };
                }

                return _equivalentProfiles;
            }
        }

        private static KeyValuePair<string, string>[] _subSetFrameworks;
        public IEnumerable<KeyValuePair<string, string>> SubSetFrameworks
        {
            get
            {
                if (_subSetFrameworks == null)
                {
                    _subSetFrameworks = new KeyValuePair<string, string>[]
                    {
                        // .NETCore is a subset of the .NET framework
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, FrameworkConstants.FrameworkIdentifiers.Net),

                        // .NET is a subset of DNX
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.Net, FrameworkConstants.FrameworkIdentifiers.Dnx),

                        // CoreCLR is a subset of DNXCore
                        new KeyValuePair<string, string>(FrameworkConstants.FrameworkIdentifiers.CoreCLR, FrameworkConstants.FrameworkIdentifiers.DnxCore),
                    };
                }

                return _subSetFrameworks;
            }
        }

        private static OneWayCompatibilityMappingEntry[] _compatibilityMappings;
        public IEnumerable<OneWayCompatibilityMappingEntry> CompatibilityMappings
        {
            get
            {
                if (_compatibilityMappings == null)
                {
                    _compatibilityMappings = new OneWayCompatibilityMappingEntry[]
                    {
                        // .NETFramework projects support native references
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetFrameworkCore, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion))),

                        // CoreCLR supports native references
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.CoreCLR, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.CoreCLR, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion))),

                        // Net46 supports Core50
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Net, new Version(4, 6, 0, 0)),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Net, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.CoreCLR, FrameworkConstants.Version5),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.CoreCLR, FrameworkConstants.Version5))),

                        // DNX supports AspNet
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Dnx, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Dnx, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.AspNet, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.AspNet, FrameworkConstants.EmptyVersion))),

                        // DNXCore supports AspNetCore
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.DnxCore, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.DnxCore, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.AspNetCore, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.AspNetCore, FrameworkConstants.EmptyVersion))),

                        // Win projects support WinRT
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Windows, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Windows, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WinRT, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.WinRT, new Version(4, 5, 0, 0)))),

                        // Win projects support Native
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Windows, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Windows, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion))),

                        // NetCore supports native
                        new OneWayCompatibilityMappingEntry(new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.NetCore, FrameworkConstants.MaxVersion)),
                            new FrameworkRange(
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion),
                                new NuGetFramework(FrameworkConstants.FrameworkIdentifiers.Native, FrameworkConstants.EmptyVersion))),
                    };
                }

                return _compatibilityMappings;
            }
        }

        private static IFrameworkMappings _instance;
        /// <summary>
        /// Singleton instance of the default framework mappings.
        /// </summary>
        public static IFrameworkMappings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DefaultFrameworkMappings();
                }

                return _instance;
            }
        }
    }
}
