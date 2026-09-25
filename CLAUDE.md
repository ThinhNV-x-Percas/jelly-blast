# Jelly Blast — quy tắc cho Claude Code

## Luật bắt buộc

- **Không dùng sub agent.** Không gọi tool `Agent`/`Task`, không chạy `Workflow`, không spawn agent song song hay chạy nền. Tự làm tuần tự trong phiên chính. Lý do: sub agent dễ chạm session/token limit giữa chừng, để lại file sửa dở và không có báo cáo.
- Việc lớn thì chia thành từng bước nhỏ, commit sau mỗi bước build sạch, để nếu phiên bị dừng thì không mất việc.

## Bối cảnh project

- Unity 2022.3, code game ở `Assets/Scripts/Assembly-CSharp/`, được khôi phục từ bản build IL2CPP (Cpp2IL + AssetRipper) rồi clean lại bằng tay.
- Bản decompile gốc (có `NativeSource` = logic native) nằm ở commit `fe27775f`: `git show fe27775f:Assets/Scripts/Assembly-CSharp/<File>.cs`.
- Không đổi tên hoặc kiểu của field public / `[SerializeField]`, tên class, tên file hay `.meta`, vì prefab và scene tham chiếu theo tên field và GUID. Tên field trong `PlayerData` chính là format file save.
- Shader trong `Assets/Shader` phần lớn là dummy hoặc viết lại bằng tay. Source Metal gốc lấy được từ bundle iOS (`Test/Input/JellyBlastV2/.../data.unity3d`) bằng UnityPy.
