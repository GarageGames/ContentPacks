   // START: Kralmok Sequences
   %seqPrefix = "Kralmok_";
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Back.dae Back", "Kralmok_Back", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Crouch_Forward.dae Crouch_Forward", "Kralmok_Crouch_Forward", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Crouch_Root.dae Crouch_Root", "Kralmok_Crouch_Root", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Crouch_Side.dae Crouch_Side", "Kralmok_Crouch_Side", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Death1.dae Death1", "Kralmok_Death1", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Fall.dae Fall", "Kralmok_Fall", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Head.dae Head", "Kralmok_Head", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Idle_Fidget1.dae Idle_Fidget1", "Kralmok_Idle_Fidget1", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Jump.dae Jump", "Kralmok_Jump", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Land.dae Land", "Kralmok_Land", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Look.dae Look", "Kralmok_Look", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Root.dae Root", "Kralmok_Root", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Run.dae Run", "Kralmok_Run", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Side.dae Side", "Kralmok_Side", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Sprint_Forward.dae Sprint_Forward", "Kralmok_Sprint_Forward", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kralmok/PlayerAnims/Mantis_Kralmok_Reload.dae Reload", "Kralmok_Reload", "0", "-1", true, true);

   %this.setSequenceCyclic("Kralmok_Back", true);
   %this.setSequenceCyclic("Kralmok_Crouch_Forward", true);
   %this.setSequenceCyclic("Kralmok_Crouch_Root", true);
   %this.setSequenceCyclic("Kralmok_Crouch_Side", true);
   %this.setSequenceCyclic("Kralmok_Death1", false);
   %this.setSequenceCyclic("Kralmok_Fall", true);
   %this.setSequenceCyclic("Kralmok_Head", false);
   %this.setSequenceCyclic("Kralmok_Idle_Fidget1", false);
   %this.setSequenceCyclic("Kralmok_Jump", false);
   %this.setSequenceCyclic("Kralmok_Land", false);
   %this.setSequenceCyclic("Kralmok_Look", false);
   %this.setSequenceCyclic("Kralmok_Root", true);
   %this.setSequenceCyclic("Kralmok_Run", true);
   %this.setSequenceCyclic("Kralmok_Side", true);
   %this.setSequenceCyclic("Kralmok_Sprint_Forward", true);
   %this.setSequenceCyclic("Kralmok_Reload", false);

   %this.setSequenceBlend( "Kralmok_Head", "1", "Kralmok_Root", "0");
   %this.setSequenceBlend( "Kralmok_Look", "1", "Kralmok_Root", "0");
   %this.setSequenceBlend( "Kralmok_Reload", "1", "Kralmok_Root", "0");
   // END: Kralmok Sequences

echo(" -- Mantis Kralmok Animations Loaded");