// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class POE_TaneOctaviusCardEditorTarget : TargetRules
{
	public POE_TaneOctaviusCardEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "POE_TaneOctaviusCard" } );
	}
}
