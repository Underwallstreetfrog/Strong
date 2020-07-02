﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix
{
	using System;
	using Anamnesis;
	using Anamnesis.Offsets;

	[Serializable]
	public static class Offsets
	{
		public static MainOffsetFile Main;

		static Offsets()
		{
			Main = new MainOffsetFile();

			Main.ActorTable = 0x1C65570;
			Main.GposeActorTable = 0x1C67000;
			Main.Gpose = 0x1C64168;
			Main.GposeCheck = 0x1CB4C9A;
			Main.GposeCheck2 = 0x1C67D50;
			Main.Target = 0x1C641D0;
			Main.CameraAddress = 0x1C63F80;
			Main.Time = 0x1C44AF8;
			Main.WeatherAddress = 0x1C1B858;
			Main.TerritoryAddress = 0x1C42430;
			Main.GposeFilters = 0x1C42BB8;
			Main.MusicOffset = 0x1C81CA8;

			Main.Skeleton1Flag = new FlagOffset(0x1382290, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x41, 0x0F, 0x29, 0x5C, 0x12, 0x10 }); // Base
			Main.Skeleton2Flag = new FlagOffset(0x13833BD, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x43, 0x0F, 0x29, 0x5C, 0x18, 0x10 });
			Main.Skeleton3Flag = new FlagOffset(0x1391024, new byte[] { 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x0F, 0x29, 0x5E, 0x10 });
			Main.Skeleton4flag = new FlagOffset(0x13822A0, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x41, 0x0F, 0x29, 0x44, 0x12, 0x20 }); // Scale
			Main.Skeleton5Flag = new FlagOffset(0x138221B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x41, 0x0F, 0x29, 0x24, 0x12 }); // Position
			Main.Skeleton6Flag = new FlagOffset(0x13833CD, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x43, 0x0F, 0x29, 0x44, 0x18, 0x20 }); // Scale 2
			Main.Physics1Flag = new FlagOffset(0x37AA48, new byte[] { 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x0F, 0x29, 0x48, 0x10 });
			Main.Physics2Flag = new FlagOffset(0x37AA3F, new byte[] { 0x90, 0x90, 0x90 }, new byte[] { 0x0F, 0x29, 0x00 });
			Main.Physics3Flag = new FlagOffset(0x37AA52, new byte[] { 0x90, 0x90, 0x90, 0x90 }, new byte[] { 0x0F, 0x29, 0x40, 0x20 });

			Main.RenderOffset1 = 0x431330;
			Main.RenderOffset2 = 0x431326;

			Main.Name = 0x30;
			Main.ActorID = 0x34;
			Main.ActorType = 0x8C;
			Main.ActorRender = 0x104;

			Main.Camera = 0xA0;

			Main.ActorAppearance = 0x17B8; // Starting position is Race Address Offset
			Main.Title = 0x18B2;
			Main.ModelType = 0x1888;
			Main.StatusEffect = 0x1C1C;
			Main.Animating = 0x784;

			Main.Transparency = 0x1704;
			Main.MainHand = 0x1450;
			Main.OffHand = 0x14B8;
			Main.ActorEquipment = 0x1708; // Starting position is Head Piece Address Offset'

			Main.ForceAnimation = 0xC60;
			Main.IdleAnimation = 0x18BE;
			Main.AnimationSpeed1 = 0xCD4;
			Main.AnimationSpeed2 = 0xCD8;
			Main.FreezeFacial = 0xCDC;

			Main.DataPath = new[] { 0xF0, 0X938 };
			Main.DataHead = new[] { 0xF0, 0X93C };

			Main.Position = new[] { 0xF0, 0X50 };
			Main.Rotation = new[] { 0xF0, 0X60 };
			Main.Height = new[] { 0xF0, 0X26C };
			Main.Wetness = new[] { 0xF0, 0X2B0 };
			Main.Drenched = new[] { 0xF0, 0X2BC };

			Main.BustScale = new[] { 0xF0, 0X148, 0x68 };
			Main.UniqueFeatureScale = new[] { 0xF0, 0X148, 0x74 }; // Tail & Ears.
			Main.MuscleTone = new[] { 0xF0, 0X240, 0x28, 0x20, 0x0C };
			Main.Scale = new[] { 0xF0, 0x70 };

			Main.MainHandScale = new[] { 0xF0, 0x30, 0x70 };
			Main.MainHandColor = new[] { 0xF0, 0x30, 0x258 };
			Main.OffhandScale = new[] { 0xF0, 0x30, 0x28, 0x70 };
			Main.OffhandColor = new[] { 0xF0, 0x30, 0x28, 0x258 };

			Main.SkinColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x00 };
			Main.SkinGloss = new[] { 0xF0, 0x240, 0x28, 0x20, 0x10 };
			Main.HairColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x30 };
			Main.HairGloss = new[] { 0xF0, 0x240, 0x28, 0x20, 0x40 };
			Main.HairHiglight = new[] { 0xF0, 0x240, 0x28, 0x20, 0x50 };
			Main.LeftEyeColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x60 };
			Main.RightEyeColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x70 };
			Main.MouthColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x20 };
			Main.MouthGloss = new[] { 0xF0, 0x240, 0x28, 0x20, 0x2C };
			Main.LimbalColor = new[] { 0xF0, 0x240, 0x28, 0x20, 0x80 };

			Main.CameraView = 0x180;
			Main.CameraCurrentZoom = 0x114;
			Main.CameraMinZoom = 0x118;
			Main.CameraMaxZoom = 0x11c;
			Main.FOVCurrent = 0x12c; // 0x120 or 0x124 or 0x12c
			Main.CameraAngle = 0x130;
			Main.CameraPan = 0x150;
			Main.CameraYMin = 0x14C;
			Main.CameraYMax = 0x148;
			Main.CameraRotation = 0x160;
			Main.CameraUpDown = 0x218;

			Main.TimeControl = new[] { 0x10, 0X08, 0x28, 0x80 };
			Main.Territory = new[] { 0x00, 0X134C };
			Main.Weather = 0x20;
			Main.ForceWeather = 0x26; // From GposeFilters

			Main.GposeFilterEnable = 0x37B;
			Main.GposeFilterTable = 0x318;

			Main.ExHairCount = new[] { 0xF0, 0xA0, 0x68, 0x4C0, 0x10 };
			Main.ExMetCount = new[] { 0xF0, 0xA0, 0x68, 0x680, 0x10 };
			Main.ExTopCount = new[] { 0xF0, 0xA0, 0x68, 0x840, 0x10 };
		}

		public class MainOffsetFile
		{
			#pragma warning disable CS8618

			public ActorTableOffset ActorTable { get; set; }
			public ActorTableOffset GposeActorTable { get; set; }
			public BaseOffset Gpose { get; set; }
			public BaseOffset<bool> GposeCheck { get; set; }
			public BaseOffset<ushort> GposeCheck2 { get; set; }
			public BaseOffset Target { get; set; }
			public BaseOffset CameraAddress { get; set; }
			public BaseOffset Time { get; set; }
			public BaseOffset WeatherAddress { get; set; }
			public BaseOffset TerritoryAddress { get; set; }
			public BaseOffset GposeFilters { get; set; }
			public BaseOffset MusicOffset { get; set; }

			public FlagOffset Skeleton1Flag { get; set; }
			public FlagOffset Skeleton2Flag { get; set; }
			public FlagOffset Skeleton3Flag { get; set; }
			public FlagOffset Skeleton4flag { get; set; }
			public FlagOffset Skeleton5Flag { get; set; }
			public FlagOffset Skeleton6Flag { get; set; }
			public FlagOffset Physics1Flag { get; set; }
			public FlagOffset Physics2Flag { get; set; }
			public FlagOffset Physics3Flag { get; set; }

			public Offset RenderOffset1 { get; set; }
			public Offset RenderOffset2 { get; set; }

			public Offset<string> Name { get; set; }
			public Offset<string> ActorID { get; set; }
			public Offset<ActorTypes> ActorType { get; set; }
			public Offset<byte> ActorRender { get; set; }

			public Offset<Vector> Camera { get; set; }

			public Offset<Appearance> ActorAppearance { get; set; }
			public Offset Title { get; set; }
			public Offset<int> ModelType { get; set; }
			public Offset StatusEffect { get; set; }
			public Offset<bool> Animating { get; set; }

			public Offset Transparency { get; set; }
			public Offset<Weapon> MainHand { get; set; }
			public Offset<Weapon> OffHand { get; set; }
			public Offset<Equipment> ActorEquipment { get; set; }

			public Offset ForceAnimation { get; set; }
			public Offset IdleAnimation { get; set; }
			public Offset AnimationSpeed1 { get; set; }
			public Offset AnimationSpeed2 { get; set; }
			public Offset FreezeFacial { get; set; }

			public Offset DataPath { get; set; }
			public Offset DataHead { get; set; }

			public Offset<Vector> Position { get; set; }
			public Offset<Quaternion> Rotation { get; set; }
			public Offset Height { get; set; }
			public Offset Wetness { get; set; }
			public Offset Drenched { get; set; }

			public Offset<Vector> BustScale { get; set; }
			public Offset UniqueFeatureScale { get; set; }
			public Offset MuscleTone { get; set; }
			public Offset<Vector> Scale { get; set; }

			public Offset<Vector> MainHandScale { get; set; }
			public Offset<Color> MainHandColor { get; set; }
			public Offset<Vector> OffhandScale { get; set; }
			public Offset<Color> OffhandColor { get; set; }

			// Actor's RGB Values
			public Offset<Color> SkinColor { get; set; }
			public Offset<Color> SkinGloss { get; set; }
			public Offset<Color> HairColor { get; set; }
			public Offset<Color> HairGloss { get; set; }
			public Offset<Color> HairHiglight { get; set; }
			public Offset<Color> LeftEyeColor { get; set; }
			public Offset<Color> RightEyeColor { get; set; }
			public Offset<Color> MouthColor { get; set; }
			public Offset<float> MouthGloss { get; set; }
			public Offset<Color> LimbalColor { get; set; }

			public Offset<Vector> CameraView { get; set; }
			public Offset<float> CameraCurrentZoom { get; set; }
			public Offset<float> CameraMinZoom { get; set; }
			public Offset<float> CameraMaxZoom { get; set; }
			public Offset<float> FOVCurrent { get; set; }
			public Offset<Vector2D> CameraAngle { get; set; }
			public Offset<Vector2D> CameraPan { get; set; }
			public Offset<float> CameraYMin { get; set; }
			public Offset<float> CameraYMax { get; set; }
			public Offset<float> CameraRotation { get; set; }
			public Offset CameraUpDown { get; set; }

			public Offset<int> TimeControl { get; set; }
			public Offset<int> Territory { get; set; }
			public Offset<int> Weather { get; set; }
			public Offset<ushort> ForceWeather { get; set; }

			public Offset GposeFilterEnable { get; set; }
			public Offset GposeFilterTable { get; set; }

			public Offset<byte> ExHairCount { get; set; }
			public Offset<byte> ExMetCount { get; set; }
			public Offset<byte> ExTopCount { get; set; }
		}
	}
}
