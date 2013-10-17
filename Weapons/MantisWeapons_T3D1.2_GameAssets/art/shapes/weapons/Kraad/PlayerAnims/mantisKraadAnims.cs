   // BEGIN: Kraad Sequences
   %seqPrefix = "Kraad_";
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Back.dae Back", "Kraad_Back", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Crouch_Forward.dae Crouch_Forward", "Kraad_Crouch_Forward", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Crouch_Root.dae Crouch_Root", "Kraad_Crouch_Root", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Crouch_Side.dae Crouch_Side", "Kraad_Crouch_Side", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Death1.dae Death1", "Kraad_Death1", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Fall.dae Fall", "Kraad_Fall", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Head.dae Head", "Kraad_Head", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Idle_Fidget1.dae Idle_Fidget1", "Kraad_Idle_Fidget1", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Jump.dae Jump", "Kraad_Jump", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Land.dae Land", "Kraad_Land", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Look.dae Look", "Kraad_Look", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Root.dae Root", "Kraad_Root", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Run.dae Run", "Kraad_Run", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Side.dae Side", "Kraad_Side", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Sprint_Forward.dae Sprint_Forward", "Kraad_Sprint_Forward", "0", "-1", true, true);
   %this.addSequence("art/shapes/weapons/Kraad/PlayerAnims/Mantis_Kraad_Reload.dae Reload", "Kraad_Reload", "0", "-1", true, true);

   %this.setSequenceCyclic("Kraad_Back", true);
   %this.setSequenceCyclic("Kraad_Crouch_Forward", true);
   %this.setSequenceCyclic("Kraad_Crouch_Root", true);
   %this.setSequenceCyclic("Kraad_Crouch_Side", true);
   %this.setSequenceCyclic("Kraad_Death1", false);
   %this.setSequenceCyclic("Kraad_Fall", true);
   %this.setSequenceCyclic("Kraad_Head", false);
   %this.setSequenceCyclic("Kraad_Idle_Fidget1", false);
   %this.setSequenceCyclic("Kraad_Jump", false);
   %this.setSequenceCyclic("Kraad_Land", false);
   %this.setSequenceCyclic("Kraad_Look", false);
   %this.setSequenceCyclic("Kraad_Root", true);
   %this.setSequenceCyclic("Kraad_Run", true);
   %this.setSequenceCyclic("Kraad_Side", true);
   %this.setSequenceCyclic("Kraad_Sprint_Forward", true);
   %this.setSequenceCyclic("Kraad_Reload", false);

   %this.setSequenceBlend( "Kraad_Head", "1", "Kraad_Root", "0");
   %this.setSequenceBlend( "Kraad_Look", "1", "Kraad_Root", "0");
   %this.setSequenceBlend( "Kraad_Reload", "1", "Kraad_Root", "0");
   // END: Kraad Sequences
echo(" -- Kraad Animations Loaded");
