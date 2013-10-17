singleton TSShapeConstructor(Soldier_Kral_SittingDAE)
{
   baseShape = "./Soldier_Kral_Sitting.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_SittingDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Sitting", "1270", "1275", true, true);
}
