# Changelog

## [0.2.0](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.12..0.2.0) - 2026-06-14

### 🚜 Refactor

- Replace `Utils.IsPlaying` with `Utils.IsPlaying2` for improved play state checks in `LogManager` - ([e46725f](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/e46725fc5eb22c638acc319f6d88186586d84f8c))
- Simplify localization handling and improve validation logic in `LogManager` - ([a299cbd](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/a299cbd10bb920b0b387816179375c7a8882701a))

### ⚙️ Miscellaneous Tasks

- Update Unity package dependencies to latest versions - ([7b28b92](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/7b28b9290dcbfa7b79d204ac2276b46f8c8770eb))
- Bump `Log Manager` to version 0.2.0 and update package metadata - ([5bd2f1a](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/5bd2f1ac7277fa4870537fc33b818bc0b89f4d7e))
- Add `yky-toolkit` dependency to package-lock file - ([6f954fa](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/6f954fa21f44b762bfd5083536e2d3a763c2ded7))
- Update dependencies and release automation workflows - ([57d4467](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/57d4467b3098cb8fc340e36f7e12bcdf38e3e687))


## [0.1.12](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.11..0.1.12) - 2025-12-02

### 🐛 Bug Fixes

- Simplify TMP_InputField assignment in OnValidate - ([f8e7327](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/f8e7327e98edd1ec77a20bac4999ea9d40ab6088))

### 🚜 Refactor

- Simplify localization handling and enforce consistent class accessibility in editor components - ([1723f0a](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/1723f0a72bb9ef404cfa1ae43960cf4e716cdaaf))

### ⚙️ Miscellaneous Tasks

- Bump `Log Manager` to version 0.1.12 - ([afa6b04](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/afa6b0419e0521ead9b4d930dcd7f575a44bc3ed))


## [0.1.11](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.10..0.1.11) - 2025-12-02

### 🐛 Bug Fixes

- Automatically instantiate `LogManager` prefab in editor during validation - ([87e4140](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/87e41400df4a4ed50187cf91c04ffffd73df409f))

### 🚜 Refactor

- Implement localization support across Log Manager editor components - ([428fa47](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/428fa47a7972f99bc400055a89273136398d5a9a))

### ⚙️ Miscellaneous Tasks

- Bump `Log Manager` to version 0.1.11 - ([036655b](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/036655b342064a099a5546524393aa15aa73dc4f))


## [0.1.10](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.9..0.1.10) - 2025-12-01

### 🚜 Refactor

- Replace `[PostProcessScene]` with `IProcessSceneWithReport` for better scene processing management - ([e8fb690](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/e8fb6909b7d8fa7f652e465de6bb44d9c271e407))

### ⚙️ Miscellaneous Tasks

- Bump `Log Manager` to version 0.1.10 - ([8681c41](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/8681c413c56fe4c741ae91e345c1f4d8e19f01df))


## [0.1.9](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.8..0.1.9) - 2025-12-01

### 🐛 Bug Fixes

- Ensure all logging methods check for Play mode before execution - ([8043714](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/804371418bbcaa7e477b30499d97f8cc7ed2ff3f))

### ⚙️ Miscellaneous Tasks

- Bump `Log Manager` to version 0.1.9 - ([d371fdd](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/d371fddbc61faaeae358d3739509e8e5b59c26c2))


## [0.1.8](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.7..0.1.8) - 2025-12-01

### 🐛 Bug Fixes

- Prevent `AddLog` execution when not in Play mode - ([0e17bd3](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/0e17bd311f3469d924ee9001422bc3404f2f5979))

### ⚙️ Miscellaneous Tasks

- Bump `Log Manager` to version 0.1.8 - ([d073cd4](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/d073cd426cacad42ee5c2de074f66fde72aa2c34))
- Bump package versions (`io.github.ykysnk.utils.world` to 0.0.5, `io.github.ykysnk.utils` to 0.6.0, `com.vrchat.base` and `com.vrchat.worlds` to 3.10.0) - ([5fb615c](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/5fb615c786cc939679da9d96303ad49c1d20e424))


## [0.1.7](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.6..0.1.7) - 2025-11-20

### ⚙️ Miscellaneous Tasks

- Bump `io.github.ykysnk.utils` to 0.3.1 and `io.github.ykysnk.cheat-client-protector` to 0.2.1 - ([c40ee12](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/c40ee1226a85da04ce5921a6ae56f3dc3ebd849c))
- Add nullability annotations to `LogManager` and `LogPanel` methods and bump version to 0.1.7 - ([c96acd8](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/c96acd8e8cbf0b0deea98fc0bd0c4ec07a8a1799))
- Trigger release workflow on changes to `Log Manager` package.json - ([2004e93](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/2004e93aa44553a3ec6f13f6bc9d06539a093589))


## [0.1.6](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.5..0.1.6) - 2025-11-18

### ⚙️ Miscellaneous Tasks

- Move `Log Manager` runtime files to `Scripts` directory to improve project organization - ([81745d1](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/81745d175ecca136a17803193f11085c4b365897))
- Add XML documentation to `ILogManager` and `LogManager` methods and classes - ([d267dde](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/d267dde0b3d949690ef38d521b5493926920cb80))
- Add scrolling and layout handling functionality to `LogPanel` and update package version to 0.1.6 - ([0f87ffc](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/0f87ffcd38a1f91833ec7c267246ada5ede0102a))


## [0.1.5](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.4..0.1.5) - 2025-11-18

### 🐛 Bug Fixes

- Update log message in `Test` interaction method - ([d7c4fce](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/d7c4fce8b00af548b630d16ba1cf29534c9b8218))
- Replace `RandomKeyPublic` with `RandomKey` in `Test` logging methods - ([ebc5135](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/ebc51351ac84cb4be56797fddc09ab45627f4d20))

### ⚙️ Miscellaneous Tasks

- Add `UdonSharpOptimizer` dependency and update `Log Manager` to version 0.1.5 - ([b5397d5](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/b5397d5a2730ecbd719a1e709bf55116bd731bb1))


## [0.1.4](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.3..0.1.4) - 2025-11-18

### ⚙️ Miscellaneous Tasks

- Update `Log Manager` to 0.1.4, bump `Cheat Client Protector` to 0.2.0, and refactor key validation method - ([e7f69e9](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/e7f69e908451e6a14ca27bf4fa9c4587826c3708))


## [0.1.3](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.2..0.1.3) - 2025-11-18

### ⚙️ Miscellaneous Tasks

- Bump `io.github.ykysnk.utils` to 0.3.0 and update `Log Manager` dependencies - ([5e3fdf9](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/5e3fdf966cf101aa4781f510037f3ed2062faec3))


## [0.1.2](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.1..0.1.2) - 2025-11-18

### ⚙️ Miscellaneous Tasks

- Remove `io.github.ykysnk.utils.world` dependency from `Log Manager` package - ([87eb398](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/87eb398e4bfef57959b2625b86c543e4f2cfca48))
- Bump `io.github.ykysnk.utils` to 0.2.8 and `Log Manager` to 0.1.2; update dependencies - ([0eb5bed](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/0eb5bed1b7a793b7dfa5c13c2445c1e7bcc352da))


## [0.1.1](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.1.0..0.1.1) - 2025-11-18

### ⚙️ Miscellaneous Tasks

- Update `LogPanel` to use `Utils.LogError` and increment package version to 0.1.1 - ([4b3ee61](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/4b3ee615a4bed275ba3ea0e17cdbd83d741673f4))


## [0.1.0](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/compare/0.0.1..0.1.0) - 2025-11-18

### ⛰️  Features

- Add `LogPanel` integration and enhance `LogManager` functionality in the editor and runtime. - ([736c031](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/736c031cb7e3226122228daabe1038a334220b5d))


## [0.0.1] - 2025-11-18

### 🐛 Bug Fixes

- Implement `Test` functionality and include necessary assets - ([b718017](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/b71801718873255bf9c35384686a938c8e5754cf))
- Upload files - ([b20f833](https://github.com/T2PeNBiX99wcoxKv3A4g/VPM.LogManager/commit/b20f833479ae6f4a5560ae7a9df1d1d537e11a3d))

## New Contributors ❤️

* @T2PeNBiX99wcoxKv3A4g made their first contribution

<!-- generated by git-cliff -->
