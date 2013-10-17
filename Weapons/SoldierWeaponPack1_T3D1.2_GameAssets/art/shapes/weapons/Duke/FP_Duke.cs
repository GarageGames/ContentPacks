
singleton TSShapeConstructor(FP_DukeDAE)
{
   baseShape = "./FP_Duke.DAE";
   loadLights = "0";
};

function FP_DukeDAE::onLoad(%this)
{
   // Rename ambient to timeline so that it won't play over other anims
   %this.renameSequence("ambient", "timeline");
   // Turn off cyclic on timeline so that it won't change last frame to match first frame.
   %this.setSequenceCyclic("timeline", "0");

   // Add Sequences
   %this.addSequence("timeline", "fire", "410", "420", "1", "0");
   %this.addSequence("timeline", "idle", "80", "199", "1", "0");
   %this.addSequence("timeline", "reload", "450", "518", "1", "0");
   %this.addSequence("timeline", "Run", "230", "259", "1", "0");
   %this.addSequence("timeline", "sprint", "300", "319", "1", "0");
   %this.addSequence("timeline", "Run2Sprint", "280", "290", "1", "0");
   %this.addSequence("timeline", "Sprint2Run", "340", "350", "1", "0");
   %this.addSequence("timeline", "switch_in", "10", "55", "1", "0");
   %this.addSequence("timeline", "switch_out", "550", "565", "1", "0");
   
   // Set Cyclic on Sequences
   %this.setSequenceCyclic( "fire", false );
   %this.setSequenceCyclic( "idle", true );
   %this.setSequenceCyclic( "reload", false );
   %this.setSequenceCyclic( "run", true );
   %this.setSequenceCyclic( "run2sprint", false );
   %this.setSequenceCyclic( "sprint", true );
   %this.setSequenceCyclic( "sprint2run", false );
   %this.setSequenceCyclic( "switch_in", false );
   %this.setSequenceCyclic( "switch_out", false );
}
