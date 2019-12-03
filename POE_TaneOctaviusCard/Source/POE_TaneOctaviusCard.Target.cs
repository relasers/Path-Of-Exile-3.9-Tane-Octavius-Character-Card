// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class POE_TaneOctaviusCardTarget : TargetRules
{
	public POE_TaneOctaviusCardTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "POE_TaneOctaviusCard" } );
	}
}
