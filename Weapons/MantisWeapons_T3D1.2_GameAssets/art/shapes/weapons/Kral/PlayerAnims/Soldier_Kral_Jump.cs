singleton TSShapeConstructor(Soldier_Kral_JumpDAE)
{
   baseShape = "./Soldier_Kral_Jump.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_JumpDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Jump", "975", "985", true, true);
}
