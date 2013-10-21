
singleton TSShapeConstructor(Zombie_03DAE)
{
   baseShape = "./Zombie_03.DAE";
   loadLights = "0";
   upAxis = "DEFAULT";
   lodType = "TrailingNumber";
   ignoreNodeScale = "0";
   adjustCenter = "0";
   adjustFloor = "0";
   forceUpdateMaterials = "0";
   neverImport = "null";
};

function Zombie_03DAE::onLoad(%this)
{
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Attack_01.DAE", "Attack1", "840", "900", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Attack_02.DAE", "Attack2", "930", "990", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Death_01.DAE", "Death1", "1020", "1080", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Death_02.DAE", "Death2", "1110", "1160", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Idle_01.DAE", "root3", "30", "150", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Idle_02.DAE", "root2", "180", "300", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Idle_03.DAE", "root", "330", "450", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Walk_01.DAE", "run", "500", "590", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Walk_02.DAE", "run2", "620", "710", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Run_01.DAE", "sprint1", "740", "760", "1", "1");
   %this.addSequence("art/shapes/actors/GG_Zombie/Anims/Zombie_Run_02.DAE", "sprint2", "790", "810", "1", "1");
   
   %this.setSequenceCyclic("Death2", "0");
   %this.setSequenceCyclic("Death1", "0");
   %this.setSequenceCyclic("Attack2", "0");
   %this.setSequenceCyclic("Attack1", "0");
   //%this.saveShape("art/shapes/actors/GG_Zombie/1_1/Zombie_03.dts");
}
