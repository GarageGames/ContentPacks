   // BEGIN: Ender Sequences
   %this.addSequence("./PlayerAnim_Ender_Back.dae Back", "Ender_Back", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Crouch_Back.dae Crouch_Back", "Ender_Crouch_Back", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Crouch_Forward.dae Crouch_Forward", "Ender_Crouch_Forward", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Crouch_Root.dae Crouch_Root", "Ender_Crouch_Root", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Crouch_Side.dae Crouch_Side", "Ender_Crouch_Side", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Death1.dae Death1", "Ender_Death1", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Death2.dae Death2", "Ender_Death2", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Fall.dae Fall", "Ender_Fall", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Head.dae Head", "Ender_Head", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Jump.dae Jump", "Ender_Jump", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Land.dae Land", "Ender_Land", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Look.dae Look", "Ender_Look", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Reload.dae Reload", "Ender_Reload", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Root.dae Root", "Ender_Root", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Run.dae Run", "Ender_Run", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Side.dae Side", "Ender_Side", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Sitting.dae Sitting", "Ender_Sitting", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Swim_Back.dae Swim_Back", "Ender_Swim_Back", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Swim_Forward.dae Swim_Forward", "Ender_Swim_Forward", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Swim_Idle.dae Swim_Idle", "Ender_Swim_Idle", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Swim_Left.dae Swim_Left", "Ender_Swim_Left", "0", "-1");
   %this.addSequence("./PlayerAnim_Ender_Swim_Right.dae Swim_Right", "Ender_Swim_Right", "0", "-1");

   %this.setSequenceCyclic("Ender_Back", true);
   %this.setSequenceCyclic("Ender_Crouch_Back", true);
   %this.setSequenceCyclic("Ender_Crouch_Forward", true);
   %this.setSequenceCyclic("Ender_Crouch_Root", true);
   %this.setSequenceCyclic("Ender_Crouch_Side", true);
   %this.setSequenceCyclic("Ender_Death1", false);
   %this.setSequenceCyclic("Ender_Death2", false);
   %this.setSequenceCyclic("Ender_Fall", true);
   %this.setSequenceCyclic("Ender_Head", false);
   %this.setSequenceCyclic("Ender_Jump", false);
   %this.setSequenceCyclic("Ender_Land", true);
   %this.setSequenceCyclic("Ender_Look", false);
   %this.setSequenceCyclic("Ender_Reload", false);
   %this.setSequenceCyclic("Ender_Root", true);
   %this.setSequenceCyclic("Ender_Run", true);
   %this.setSequenceCyclic("Ender_Side", true);
   %this.setSequenceCyclic("Ender_Sitting", true);
   %this.setSequenceCyclic("Ender_Swim_Back", true);
   %this.setSequenceCyclic("Ender_Swim_Forward", true);
   %this.setSequenceCyclic("Ender_Swim_Idle", true);
   %this.setSequenceCyclic("Ender_Swim_Left", true);
   %this.setSequenceCyclic("Ender_Swim_Right", true);
   
   %this.setSequenceBlend( "Ender_Head", "1", "Ender_Root", "0");
   %this.setSequenceBlend( "Ender_Look", "1", "Ender_Root", "0");
   %this.setSequenceBlend( "Ender_Reload", "1", "Ender_Root", "0");
   
   %this.setSequenceGroundSpeed( "Ender_Back", "0 -3.6 0");
   %this.setSequenceGroundSpeed( "Ender_Run", "0 3.6 0");
   %this.setSequenceGroundSpeed( "Ender_Side", "3.6 0 0");
   %this.setSequenceGroundSpeed( "Ender_Swim_Backward", "0 -1 0");
   %this.setSequenceGroundSpeed( "Ender_Swim_Forward", "0 1 0");
   %this.setSequenceGroundSpeed( "Ender_Swim_Left", "1 0 0");
   %this.setSequenceGroundSpeed( "Ender_Swim_Right", "-1 0 0");
   %this.setSequenceGroundSpeed( "Ender_Crouch_Backward", "0 -1 0");
   %this.setSequenceGroundSpeed( "Ender_Crouch_Forward", "0 1 0");
   %this.setSequenceGroundSpeed( "Ender_Crouch_Side", "1 0 0");
   // END: Ender Sequences

echo(" -- Ender Animations Loaded");