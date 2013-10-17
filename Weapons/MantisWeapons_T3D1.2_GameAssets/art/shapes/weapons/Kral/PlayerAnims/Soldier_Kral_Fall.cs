singleton TSShapeConstructor(Soldier_Kral_FallDAE)
{
   baseShape = "./Soldier_Kral_Fall.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Soldier_Kral_FallDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Fall", "1015", "1045", true, true);
}
