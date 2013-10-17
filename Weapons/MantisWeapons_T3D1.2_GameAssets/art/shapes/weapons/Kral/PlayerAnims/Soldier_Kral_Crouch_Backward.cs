singleton TSShapeConstructor(Soldier_Kral_Crouch_BackwardDAE)
{
   baseShape = "./Soldier_Kral_Crouch_Backward.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_Crouch_BackwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Backward", "450", "479", true, true);
}
